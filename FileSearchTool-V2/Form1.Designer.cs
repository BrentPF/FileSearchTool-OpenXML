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
			this.components = new System.ComponentModel.Container();
			this.resultList = new System.Windows.Forms.ListBox();
			this.consoleList = new System.Windows.Forms.ListBox();
			this.searchBtn = new System.Windows.Forms.Button();
			this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.folderBtn = new System.Windows.Forms.Button();
			this.searchTxt = new System.Windows.Forms.TextBox();
			this.folderTxt = new System.Windows.Forms.TextBox();
			this.progressLbl = new System.Windows.Forms.Label();
			this.outputLbl = new System.Windows.Forms.Label();
			this.consoleLbl = new System.Windows.Forms.Label();
			this.fileFetchWorker = new System.ComponentModel.BackgroundWorker();
			this.runTimer = new System.Windows.Forms.Timer(this.components);
			this.timerLbl = new System.Windows.Forms.Label();
			this.countLbl = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// resultList
			// 
			this.resultList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.resultList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.resultList.FormattingEnabled = true;
			this.resultList.HorizontalScrollbar = true;
			this.resultList.ItemHeight = 20;
			this.resultList.Location = new System.Drawing.Point(12, 155);
			this.resultList.Name = "resultList";
			this.resultList.Size = new System.Drawing.Size(880, 324);
			this.resultList.TabIndex = 0;
			// 
			// consoleList
			// 
			this.consoleList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.consoleList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.consoleList.FormattingEnabled = true;
			this.consoleList.HorizontalScrollbar = true;
			this.consoleList.ItemHeight = 20;
			this.consoleList.Location = new System.Drawing.Point(12, 523);
			this.consoleList.Name = "consoleList";
			this.consoleList.Size = new System.Drawing.Size(880, 104);
			this.consoleList.TabIndex = 1;
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
			this.progressLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.progressLbl.Location = new System.Drawing.Point(11, 77);
			this.progressLbl.Name = "progressLbl";
			this.progressLbl.Size = new System.Drawing.Size(457, 20);
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
			this.consoleLbl.AutoSize = true;
			this.consoleLbl.Location = new System.Drawing.Point(12, 507);
			this.consoleLbl.Name = "consoleLbl";
			this.consoleLbl.Size = new System.Drawing.Size(45, 13);
			this.consoleLbl.TabIndex = 9;
			this.consoleLbl.Text = "Console";
			// 
			// fileFetchWorker
			// 
			this.fileFetchWorker.WorkerReportsProgress = true;
			this.fileFetchWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.FileFetchWorker_DoWork);
			this.fileFetchWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.FileFetchWorker_ProgressChanged);
			this.fileFetchWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.FileFetchWorker_RunWorkerCompleted);
			// 
			// runTimer
			// 
			this.runTimer.Interval = 1000;
			this.runTimer.Tick += new System.EventHandler(this.RunTimer_Tick);
			// 
			// timerLbl
			// 
			this.timerLbl.AutoSize = true;
			this.timerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.timerLbl.Location = new System.Drawing.Point(11, 97);
			this.timerLbl.Name = "timerLbl";
			this.timerLbl.Size = new System.Drawing.Size(185, 20);
			this.timerLbl.TabIndex = 10;
			this.timerLbl.Text = "Time (Elapsed): 00:00:00";
			// 
			// countLbl
			// 
			this.countLbl.AutoSize = true;
			this.countLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.countLbl.Location = new System.Drawing.Point(11, 117);
			this.countLbl.Name = "countLbl";
			this.countLbl.Size = new System.Drawing.Size(138, 20);
			this.countLbl.TabIndex = 11;
			this.countLbl.Text = "Files Processed: 0";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(906, 656);
			this.Controls.Add(this.countLbl);
			this.Controls.Add(this.timerLbl);
			this.Controls.Add(this.consoleLbl);
			this.Controls.Add(this.outputLbl);
			this.Controls.Add(this.progressLbl);
			this.Controls.Add(this.folderTxt);
			this.Controls.Add(this.searchTxt);
			this.Controls.Add(this.folderBtn);
			this.Controls.Add(this.searchBtn);
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
		private System.Windows.Forms.Button searchBtn;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
		private System.Windows.Forms.Button folderBtn;
		private System.Windows.Forms.TextBox searchTxt;
		private System.Windows.Forms.TextBox folderTxt;
		private System.Windows.Forms.Label progressLbl;
		private System.Windows.Forms.Label outputLbl;
		private System.Windows.Forms.Label consoleLbl;
		private System.ComponentModel.BackgroundWorker fileFetchWorker;
		private System.Windows.Forms.Timer runTimer;
		private System.Windows.Forms.Label timerLbl;
		private System.Windows.Forms.Label countLbl;
	}
}

