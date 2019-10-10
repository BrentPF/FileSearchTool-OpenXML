namespace FileSearchTool_V2
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.resultList = new System.Windows.Forms.ListBox();
			this.consoleList = new System.Windows.Forms.ListBox();
			this.progressBar = new System.Windows.Forms.ProgressBar();
			this.searchBtn = new System.Windows.Forms.Button();
			this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.folderBtn = new System.Windows.Forms.Button();
			this.searchTxt = new System.Windows.Forms.TextBox();
			this.folderTxt = new System.Windows.Forms.TextBox();
			this.progressLbl = new System.Windows.Forms.Label();
			this.outputLbl = new System.Windows.Forms.Label();
			this.consoleLbl = new System.Windows.Forms.Label();
			this.fileFetchWorker = new System.ComponentModel.BackgroundWorker();
			this.fileParseWorker = new System.ComponentModel.BackgroundWorker();
			this.SuspendLayout();
			// 
			// resultList
			// 
			this.resultList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.resultList.FormattingEnabled = true;
			this.resultList.HorizontalScrollbar = true;
			this.resultList.Location = new System.Drawing.Point(12, 155);
			this.resultList.Name = "resultList";
			this.resultList.Size = new System.Drawing.Size(880, 342);
			this.resultList.TabIndex = 0;
			// 
			// consoleList
			// 
			this.consoleList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.consoleList.FormattingEnabled = true;
			this.consoleList.HorizontalScrollbar = true;
			this.consoleList.Location = new System.Drawing.Point(12, 523);
			this.consoleList.Name = "consoleList";
			this.consoleList.Size = new System.Drawing.Size(880, 121);
			this.consoleList.TabIndex = 1;
			// 
			// progressBar
			// 
			this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.progressBar.Location = new System.Drawing.Point(12, 100);
			this.progressBar.Name = "progressBar";
			this.progressBar.Size = new System.Drawing.Size(880, 23);
			this.progressBar.TabIndex = 2;
			// 
			// searchBtn
			// 
			this.searchBtn.Location = new System.Drawing.Point(12, 22);
			this.searchBtn.Name = "searchBtn";
			this.searchBtn.Size = new System.Drawing.Size(120, 23);
			this.searchBtn.TabIndex = 3;
			this.searchBtn.Text = "Search";
			this.searchBtn.UseVisualStyleBackColor = true;
			this.searchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
			// 
			// folderBtn
			// 
			this.folderBtn.Location = new System.Drawing.Point(12, 51);
			this.folderBtn.Name = "folderBtn";
			this.folderBtn.Size = new System.Drawing.Size(120, 23);
			this.folderBtn.TabIndex = 4;
			this.folderBtn.Text = "Select Folder";
			this.folderBtn.UseVisualStyleBackColor = true;
			this.folderBtn.Click += new System.EventHandler(this.FolderBtn_Click);
			// 
			// searchTxt
			// 
			this.searchTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.searchTxt.Location = new System.Drawing.Point(137, 24);
			this.searchTxt.Name = "searchTxt";
			this.searchTxt.Size = new System.Drawing.Size(755, 20);
			this.searchTxt.TabIndex = 5;
			// 
			// folderTxt
			// 
			this.folderTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.folderTxt.Location = new System.Drawing.Point(138, 52);
			this.folderTxt.Name = "folderTxt";
			this.folderTxt.ReadOnly = true;
			this.folderTxt.Size = new System.Drawing.Size(755, 20);
			this.folderTxt.TabIndex = 6;
			// 
			// progressLbl
			// 
			this.progressLbl.AutoSize = true;
			this.progressLbl.Location = new System.Drawing.Point(12, 84);
			this.progressLbl.Name = "progressLbl";
			this.progressLbl.Size = new System.Drawing.Size(306, 13);
			this.progressLbl.TabIndex = 7;
			this.progressLbl.Text = "Please enter a search term and select a parent folder to search.";
			// 
			// outputLbl
			// 
			this.outputLbl.AutoSize = true;
			this.outputLbl.Location = new System.Drawing.Point(12, 139);
			this.outputLbl.Name = "outputLbl";
			this.outputLbl.Size = new System.Drawing.Size(39, 13);
			this.outputLbl.TabIndex = 8;
			this.outputLbl.Text = "Output";
			// 
			// consoleLbl
			// 
			this.consoleLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.consoleLbl.AutoSize = true;
			this.consoleLbl.Location = new System.Drawing.Point(12, 507);
			this.consoleLbl.Name = "consoleLbl";
			this.consoleLbl.Size = new System.Drawing.Size(45, 13);
			this.consoleLbl.TabIndex = 9;
			this.consoleLbl.Text = "Console";
			// 
			// fileFetchWorker
			// 
			this.fileFetchWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.FileFetchWorker_DoWork);
			this.fileFetchWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.FileFetchWorker_RunWorkerCompleted);
			// 
			// fileParseWorker
			// 
			this.fileParseWorker.WorkerReportsProgress = true;
			this.fileParseWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.FileParseWorker_DoWork);
			this.fileParseWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.FileParseWorker_ProgressChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(906, 656);
			this.Controls.Add(this.consoleLbl);
			this.Controls.Add(this.outputLbl);
			this.Controls.Add(this.progressLbl);
			this.Controls.Add(this.folderTxt);
			this.Controls.Add(this.searchTxt);
			this.Controls.Add(this.folderBtn);
			this.Controls.Add(this.searchBtn);
			this.Controls.Add(this.progressBar);
			this.Controls.Add(this.consoleList);
			this.Controls.Add(this.resultList);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox resultList;
		private System.Windows.Forms.ListBox consoleList;
		private System.Windows.Forms.ProgressBar progressBar;
		private System.Windows.Forms.Button searchBtn;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
		private System.Windows.Forms.Button folderBtn;
		private System.Windows.Forms.TextBox searchTxt;
		private System.Windows.Forms.TextBox folderTxt;
		private System.Windows.Forms.Label progressLbl;
		private System.Windows.Forms.Label outputLbl;
		private System.Windows.Forms.Label consoleLbl;
		private System.ComponentModel.BackgroundWorker fileFetchWorker;
		private System.ComponentModel.BackgroundWorker fileParseWorker;
	}
}

