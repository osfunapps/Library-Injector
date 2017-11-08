namespace Library_Injecter
{
    partial class LibraryForm
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
            this.logBtn = new System.Windows.Forms.LinkLabel();
            this.sourcesGB = new System.Windows.Forms.GroupBox();
            this.LibraryFileBrowseBtn = new System.Windows.Forms.Button();
            this.libraryFileTB = new System.Windows.Forms.TextBox();
            this.libraryfileLabel = new System.Windows.Forms.Label();
            this.ProjectRootBrowseBtn = new System.Windows.Forms.Button();
            this.projectsRootTB = new System.Windows.Forms.TextBox();
            this.projectRootLabel = new System.Windows.Forms.Label();
            this.outputFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.outputGB = new System.Windows.Forms.GroupBox();
            this.outputRTB = new System.Windows.Forms.RichTextBox();
            this.goBtn = new System.Windows.Forms.Button();
            this.pythonPathDialog = new System.Windows.Forms.OpenFileDialog();
            this.sourcesGB.SuspendLayout();
            this.outputGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // logBtn
            // 
            this.logBtn.AutoSize = true;
            this.logBtn.Location = new System.Drawing.Point(453, 492);
            this.logBtn.Name = "logBtn";
            this.logBtn.Size = new System.Drawing.Size(29, 13);
            this.logBtn.TabIndex = 20;
            this.logBtn.TabStop = true;
            this.logBtn.Text = "LOG";
            this.logBtn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logBtn_LinkClicked);
            // 
            // sourcesGB
            // 
            this.sourcesGB.Controls.Add(this.LibraryFileBrowseBtn);
            this.sourcesGB.Controls.Add(this.libraryFileTB);
            this.sourcesGB.Controls.Add(this.libraryfileLabel);
            this.sourcesGB.Controls.Add(this.ProjectRootBrowseBtn);
            this.sourcesGB.Controls.Add(this.projectsRootTB);
            this.sourcesGB.Controls.Add(this.projectRootLabel);
            this.sourcesGB.Location = new System.Drawing.Point(13, 13);
            this.sourcesGB.Name = "sourcesGB";
            this.sourcesGB.Size = new System.Drawing.Size(471, 107);
            this.sourcesGB.TabIndex = 21;
            this.sourcesGB.TabStop = false;
            this.sourcesGB.Text = "Sources";
            // 
            // LibraryFileBrowseBtn
            // 
            this.LibraryFileBrowseBtn.Location = new System.Drawing.Point(376, 68);
            this.LibraryFileBrowseBtn.Name = "LibraryFileBrowseBtn";
            this.LibraryFileBrowseBtn.Size = new System.Drawing.Size(79, 25);
            this.LibraryFileBrowseBtn.TabIndex = 18;
            this.LibraryFileBrowseBtn.Text = "Browse...";
            this.LibraryFileBrowseBtn.UseVisualStyleBackColor = true;
            this.LibraryFileBrowseBtn.Click += new System.EventHandler(this.libraryFileBrowse_Click);
            // 
            // libraryFileTB
            // 
            this.libraryFileTB.AllowDrop = true;
            this.libraryFileTB.Location = new System.Drawing.Point(92, 71);
            this.libraryFileTB.Name = "libraryFileTB";
            this.libraryFileTB.Size = new System.Drawing.Size(271, 20);
            this.libraryFileTB.TabIndex = 17;
            this.libraryFileTB.DragDrop += new System.Windows.Forms.DragEventHandler(this.LibraryFileDropHandler);
            this.libraryFileTB.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnterHandler);
            // 
            // libraryfileLabel
            // 
            this.libraryfileLabel.AutoSize = true;
            this.libraryfileLabel.Location = new System.Drawing.Point(10, 74);
            this.libraryfileLabel.Name = "libraryfileLabel";
            this.libraryfileLabel.Size = new System.Drawing.Size(57, 13);
            this.libraryfileLabel.TabIndex = 16;
            this.libraryfileLabel.Text = "Library File";
            // 
            // ProjectRootBrowseBtn
            // 
            this.ProjectRootBrowseBtn.Location = new System.Drawing.Point(376, 24);
            this.ProjectRootBrowseBtn.Name = "ProjectRootBrowseBtn";
            this.ProjectRootBrowseBtn.Size = new System.Drawing.Size(79, 25);
            this.ProjectRootBrowseBtn.TabIndex = 15;
            this.ProjectRootBrowseBtn.Text = "Browse...";
            this.ProjectRootBrowseBtn.UseVisualStyleBackColor = true;
            this.ProjectRootBrowseBtn.Click += new System.EventHandler(this.outputFolderBrowseBtn_Click);
            // 
            // projectsRootTB
            // 
            this.projectsRootTB.AllowDrop = true;
            this.projectsRootTB.Location = new System.Drawing.Point(92, 26);
            this.projectsRootTB.Name = "projectsRootTB";
            this.projectsRootTB.Size = new System.Drawing.Size(271, 20);
            this.projectsRootTB.TabIndex = 14;
            this.projectsRootTB.TextChanged += new System.EventHandler(this.projectsRootTB_TextChanged);
            this.projectsRootTB.DragDrop += new System.Windows.Forms.DragEventHandler(this.projectsRootDropHandler);
            this.projectsRootTB.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnterHandler);
            // 
            // projectRootLabel
            // 
            this.projectRootLabel.AutoSize = true;
            this.projectRootLabel.Location = new System.Drawing.Point(10, 28);
            this.projectRootLabel.Name = "projectRootLabel";
            this.projectRootLabel.Size = new System.Drawing.Size(71, 13);
            this.projectRootLabel.TabIndex = 13;
            this.projectRootLabel.Text = "Projects Root";
            // 
            // outputFolderDialog
            // 
            this.outputFolderDialog.HelpRequest += new System.EventHandler(this.outputFolderDialog_HelpRequest);
            // 
            // outputGB
            // 
            this.outputGB.Controls.Add(this.outputRTB);
            this.outputGB.Location = new System.Drawing.Point(13, 126);
            this.outputGB.Name = "outputGB";
            this.outputGB.Size = new System.Drawing.Size(471, 311);
            this.outputGB.TabIndex = 22;
            this.outputGB.TabStop = false;
            this.outputGB.Text = "Output";
            // 
            // outputRTB
            // 
            this.outputRTB.Enabled = false;
            this.outputRTB.Location = new System.Drawing.Point(13, 25);
            this.outputRTB.Name = "outputRTB";
            this.outputRTB.Size = new System.Drawing.Size(442, 269);
            this.outputRTB.TabIndex = 0;
            this.outputRTB.Text = "";
            // 
            // goBtn
            // 
            this.goBtn.Location = new System.Drawing.Point(169, 446);
            this.goBtn.Name = "goBtn";
            this.goBtn.Size = new System.Drawing.Size(150, 59);
            this.goBtn.TabIndex = 19;
            this.goBtn.Text = "Go";
            this.goBtn.UseVisualStyleBackColor = true;
            this.goBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // pythonPathDialog
            // 
            this.pythonPathDialog.FileName = "pythonPathDialog";
            this.pythonPathDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.pythonPathDialog_FileOk);
            // 
            // LibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 517);
            this.Controls.Add(this.goBtn);
            this.Controls.Add(this.outputGB);
            this.Controls.Add(this.sourcesGB);
            this.Controls.Add(this.logBtn);
            this.Name = "LibraryForm";
            this.Text = "Library Injector";
            this.sourcesGB.ResumeLayout(false);
            this.sourcesGB.PerformLayout();
            this.outputGB.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel logBtn;
        private System.Windows.Forms.GroupBox sourcesGB;
        private System.Windows.Forms.Button LibraryFileBrowseBtn;
        private System.Windows.Forms.TextBox libraryFileTB;
        private System.Windows.Forms.Label libraryfileLabel;
        private System.Windows.Forms.Button ProjectRootBrowseBtn;
        private System.Windows.Forms.TextBox projectsRootTB;
        private System.Windows.Forms.Label projectRootLabel;
        private System.Windows.Forms.FolderBrowserDialog outputFolderDialog;
        private System.Windows.Forms.GroupBox outputGB;
        private System.Windows.Forms.RichTextBox outputRTB;
        private System.Windows.Forms.Button goBtn;
        private System.Windows.Forms.OpenFileDialog pythonPathDialog;
    }
}

