using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileSearchTool_V2
{
	public partial class Form1 : Form
	{
		private Regex[] regExs = { new Regex(".*\\.docx?$"), new Regex(".*\\.xlsx?$"), new Regex(".*\\.pdf$") };
		private List<string> filePaths = new List<string>();
		public Form1()
		{
			InitializeComponent();
		}

		private void disableInterface() {
			this.searchBtn.Enabled = false;
			this.folderBtn.Enabled = false;
			this.searchTxt.Enabled = false;
		}

		private void enableInterface()
		{
			this.searchBtn.Enabled = true;
			this.folderBtn.Enabled = true;
			this.searchTxt.Enabled = true;
		}

		private void SearchAllFiles(string folder, List<string> paths)
		{
			foreach (string file in Directory.GetFiles(folder))
			{
				foreach (Regex ext in regExs)
				{
					if (ext.IsMatch(file))
					{
						paths.Add(file);
					}
				}
			}
			foreach (string subDir in Directory.GetDirectories(folder))
			{
				try
				{
					SearchAllFiles(subDir, paths);
				}
				catch
				{
					// swallow, log, whatever
				}
			}
		}

		private bool ParseAllFiles(string exp, string path) {

			if (path.EndsWith(".doc") || path.EndsWith(".docx")) {
				try {
					using (WordprocessingDocument wordDoc = WordprocessingDocument.Open(path, false))
					{
						string docText = null;
						using (StreamReader sr = new StreamReader(wordDoc.MainDocumentPart.GetStream()))
						{
							docText = sr.ReadToEnd();
						}

						if (docText.Contains(exp)) {
							System.Diagnostics.Debug.WriteLine("FILE FOUND!!!!");
							return true;
						}
					}
				} catch {

				}

			}

			return false;
		}

		private void FolderBtn_Click(object sender, EventArgs e)
		{
			if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
			{
				folderTxt.Text = folderBrowserDialog.SelectedPath;
			}
		}

		private void SearchBtn_Click(object sender, EventArgs e)
		{
			this.fileFetchWorker.RunWorkerAsync();
		}

		private void FileFetchWorker_DoWork(object sender, DoWorkEventArgs e)
		{
			SearchAllFiles(this.folderTxt.Text, filePaths);
		}

		private void FileFetchWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{/*
			foreach (string path in filePaths) {
				this.resultList.Items.Add(path);
			}*/
			this.fileParseWorker.RunWorkerAsync();
		}

		private void FileParseWorker_DoWork(object sender, DoWorkEventArgs e)
		{
			foreach (string path in filePaths)
			{
				if (ParseAllFiles(this.searchTxt.Text, path))
				{
					this.fileParseWorker.ReportProgress(1, path);
				}
				else
				{
					this.fileParseWorker.ReportProgress(0, path);
				}
			}
		}

		private void FileParseWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
		{
			this.progressLbl.Text = ("processed: " + e.UserState as string);
			if (e.ProgressPercentage == 1) {
				this.resultList.Items.Add(e.UserState as string);
			}
		}
	}
}
