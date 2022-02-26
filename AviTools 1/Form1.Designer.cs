namespace AviTools_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.fileTransferBox = new System.Windows.Forms.GroupBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBoxForDup = new System.Windows.Forms.CheckBox();
            this.checkBoxSkipFiles = new System.Windows.Forms.CheckBox();
            this.overWriteCheck = new System.Windows.Forms.CheckBox();
            this.LogBox = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backButton = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonPause = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonTranfer = new System.Windows.Forms.Button();
            this.richTextLogBox = new System.Windows.Forms.RichTextBox();
            this.StatusBox = new System.Windows.Forms.GroupBox();
            this.CountofFileTextbox = new System.Windows.Forms.TextBox();
            this.CountofFolderTextbox = new System.Windows.Forms.TextBox();
            this.FolderLeftToTransferTextBox = new System.Windows.Forms.TextBox();
            this.FilesLeftToTransferTextBox = new System.Windows.Forms.TextBox();
            this.FolderTransferedTextBox = new System.Windows.Forms.TextBox();
            this.FilesTransferedTextBox = new System.Windows.Forms.TextBox();
            this.FolderFailTextBox = new System.Windows.Forms.TextBox();
            this.fileErrors = new System.Windows.Forms.RichTextBox();
            this.filesTransfered = new System.Windows.Forms.RichTextBox();
            this.BrowseBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SourceLabel = new System.Windows.Forms.Label();
            this.listBoxForDestination = new System.Windows.Forms.ListBox();
            this.listBoxForSource = new System.Windows.Forms.ListBox();
            this.groupBoxForFilesinDir = new System.Windows.Forms.GroupBox();
            this.richTextBoxForFIieFoundinDir = new System.Windows.Forms.RichTextBox();
            this.textBoxForDestination = new System.Windows.Forms.TextBox();
            this.textBoxForsrc = new System.Windows.Forms.TextBox();
            this.FilepathsBox = new System.Windows.Forms.GroupBox();
            this.progressBarForTranfer = new System.Windows.Forms.ProgressBar();
            this.progressBarForFolder = new System.Windows.Forms.ProgressBar();
            this.FilesFailedTextBox = new System.Windows.Forms.TextBox();
            this.MyBox = new System.Windows.Forms.TextBox();
            this.fileTransferBox.SuspendLayout();
            this.LogBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.StatusBox.SuspendLayout();
            this.BrowseBox.SuspendLayout();
            this.groupBoxForFilesinDir.SuspendLayout();
            this.FilepathsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileTransferBox
            // 
            this.fileTransferBox.Controls.Add(this.checkBox4);
            this.fileTransferBox.Controls.Add(this.checkBoxForDup);
            this.fileTransferBox.Controls.Add(this.checkBoxSkipFiles);
            this.fileTransferBox.Controls.Add(this.overWriteCheck);
            this.fileTransferBox.Location = new System.Drawing.Point(12, 12);
            this.fileTransferBox.Name = "fileTransferBox";
            this.fileTransferBox.Size = new System.Drawing.Size(200, 115);
            this.fileTransferBox.TabIndex = 0;
            this.fileTransferBox.TabStop = false;
            this.fileTransferBox.Text = "File transfer option";
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(6, 88);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(100, 17);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Move file(Soon)";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBoxForDup
            // 
            this.checkBoxForDup.AutoSize = true;
            this.checkBoxForDup.Location = new System.Drawing.Point(6, 65);
            this.checkBoxForDup.Name = "checkBoxForDup";
            this.checkBoxForDup.Size = new System.Drawing.Size(90, 17);
            this.checkBoxForDup.TabIndex = 2;
            this.checkBoxForDup.Text = "Duplcate files";
            this.checkBoxForDup.UseVisualStyleBackColor = true;
            this.checkBoxForDup.CheckedChanged += new System.EventHandler(this.checkBoxForDup_CheckedChanged);
            // 
            // checkBoxSkipFiles
            // 
            this.checkBoxSkipFiles.AutoSize = true;
            this.checkBoxSkipFiles.Location = new System.Drawing.Point(6, 42);
            this.checkBoxSkipFiles.Name = "checkBoxSkipFiles";
            this.checkBoxSkipFiles.Size = new System.Drawing.Size(68, 17);
            this.checkBoxSkipFiles.TabIndex = 1;
            this.checkBoxSkipFiles.Text = "Skip files";
            this.checkBoxSkipFiles.UseVisualStyleBackColor = true;
            this.checkBoxSkipFiles.CheckedChanged += new System.EventHandler(this.checkBoxSkipFiles_CheckedChanged);
            // 
            // overWriteCheck
            // 
            this.overWriteCheck.AutoSize = true;
            this.overWriteCheck.Checked = true;
            this.overWriteCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.overWriteCheck.Location = new System.Drawing.Point(6, 19);
            this.overWriteCheck.Name = "overWriteCheck";
            this.overWriteCheck.Size = new System.Drawing.Size(92, 17);
            this.overWriteCheck.TabIndex = 0;
            this.overWriteCheck.Text = "Overwrite files";
            this.overWriteCheck.UseVisualStyleBackColor = true;
            this.overWriteCheck.CheckedChanged += new System.EventHandler(this.overWriteCheck_CheckedChanged);
            // 
            // LogBox
            // 
            this.LogBox.Controls.Add(this.progressBarForFolder);
            this.LogBox.Controls.Add(this.groupBox1);
            this.LogBox.Controls.Add(this.richTextLogBox);
            this.LogBox.Controls.Add(this.progressBarForTranfer);
            this.LogBox.Controls.Add(this.StatusBox);
            this.LogBox.Controls.Add(this.fileErrors);
            this.LogBox.Controls.Add(this.filesTransfered);
            this.LogBox.Location = new System.Drawing.Point(18, 265);
            this.LogBox.Name = "LogBox";
            this.LogBox.Size = new System.Drawing.Size(1232, 292);
            this.LogBox.TabIndex = 1;
            this.LogBox.TabStop = false;
            this.LogBox.Text = "Log";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.backButton);
            this.groupBox1.Controls.Add(this.buttonCancel);
            this.groupBox1.Controls.Add(this.buttonPause);
            this.groupBox1.Controls.Add(this.buttonBack);
            this.groupBox1.Controls.Add(this.buttonTranfer);
            this.groupBox1.Location = new System.Drawing.Point(1087, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(133, 164);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(6, 133);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "Back 2";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(6, 78);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonPause
            // 
            this.buttonPause.Location = new System.Drawing.Point(6, 49);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(75, 23);
            this.buttonPause.TabIndex = 2;
            this.buttonPause.Text = "Pause";
            this.buttonPause.UseVisualStyleBackColor = true;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(6, 104);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 1;
            this.buttonBack.Text = "Back 1";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonTranfer
            // 
            this.buttonTranfer.Location = new System.Drawing.Point(6, 20);
            this.buttonTranfer.Name = "buttonTranfer";
            this.buttonTranfer.Size = new System.Drawing.Size(75, 23);
            this.buttonTranfer.TabIndex = 0;
            this.buttonTranfer.Text = "Tranfer";
            this.buttonTranfer.UseVisualStyleBackColor = true;
            this.buttonTranfer.Click += new System.EventHandler(this.buttonTranfer_Click);
            // 
            // richTextLogBox
            // 
            this.richTextLogBox.Location = new System.Drawing.Point(786, 125);
            this.richTextLogBox.Name = "richTextLogBox";
            this.richTextLogBox.ReadOnly = true;
            this.richTextLogBox.Size = new System.Drawing.Size(295, 132);
            this.richTextLogBox.TabIndex = 4;
            this.richTextLogBox.Text = "";
            // 
            // StatusBox
            // 
            this.StatusBox.Controls.Add(this.CountofFileTextbox);
            this.StatusBox.Controls.Add(this.CountofFolderTextbox);
            this.StatusBox.Controls.Add(this.FolderLeftToTransferTextBox);
            this.StatusBox.Controls.Add(this.FilesLeftToTransferTextBox);
            this.StatusBox.Controls.Add(this.FolderTransferedTextBox);
            this.StatusBox.Controls.Add(this.FilesTransferedTextBox);
            this.StatusBox.Controls.Add(this.FolderFailTextBox);
            this.StatusBox.Controls.Add(this.FilesFailedTextBox);
            this.StatusBox.Location = new System.Drawing.Point(786, 19);
            this.StatusBox.Name = "StatusBox";
            this.StatusBox.Size = new System.Drawing.Size(295, 100);
            this.StatusBox.TabIndex = 2;
            this.StatusBox.TabStop = false;
            this.StatusBox.Text = "Status";
            // 
            // CountofFileTextbox
            // 
            this.CountofFileTextbox.BackColor = System.Drawing.SystemColors.Menu;
            this.CountofFileTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CountofFileTextbox.Location = new System.Drawing.Point(148, 58);
            this.CountofFileTextbox.Name = "CountofFileTextbox";
            this.CountofFileTextbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CountofFileTextbox.Size = new System.Drawing.Size(140, 13);
            this.CountofFileTextbox.TabIndex = 7;
            this.CountofFileTextbox.Text = "File Count: ";
            // 
            // CountofFolderTextbox
            // 
            this.CountofFolderTextbox.BackColor = System.Drawing.SystemColors.Menu;
            this.CountofFolderTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CountofFolderTextbox.Location = new System.Drawing.Point(148, 77);
            this.CountofFolderTextbox.Name = "CountofFolderTextbox";
            this.CountofFolderTextbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CountofFolderTextbox.Size = new System.Drawing.Size(140, 13);
            this.CountofFolderTextbox.TabIndex = 6;
            this.CountofFolderTextbox.Text = "Folders Count: ";
            // 
            // FolderLeftToTransferTextBox
            // 
            this.FolderLeftToTransferTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.FolderLeftToTransferTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FolderLeftToTransferTextBox.Location = new System.Drawing.Point(148, 39);
            this.FolderLeftToTransferTextBox.Name = "FolderLeftToTransferTextBox";
            this.FolderLeftToTransferTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.FolderLeftToTransferTextBox.Size = new System.Drawing.Size(140, 13);
            this.FolderLeftToTransferTextBox.TabIndex = 5;
            this.FolderLeftToTransferTextBox.Text = "Folders Left: ";
            // 
            // FilesLeftToTransferTextBox
            // 
            this.FilesLeftToTransferTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.FilesLeftToTransferTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FilesLeftToTransferTextBox.Location = new System.Drawing.Point(148, 20);
            this.FilesLeftToTransferTextBox.Name = "FilesLeftToTransferTextBox";
            this.FilesLeftToTransferTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.FilesLeftToTransferTextBox.Size = new System.Drawing.Size(140, 13);
            this.FilesLeftToTransferTextBox.TabIndex = 4;
            this.FilesLeftToTransferTextBox.Text = "Files Left: ";
            // 
            // FolderTransferedTextBox
            // 
            this.FolderTransferedTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.FolderTransferedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FolderTransferedTextBox.Location = new System.Drawing.Point(7, 77);
            this.FolderTransferedTextBox.Name = "FolderTransferedTextBox";
            this.FolderTransferedTextBox.Size = new System.Drawing.Size(140, 13);
            this.FolderTransferedTextBox.TabIndex = 3;
            this.FolderTransferedTextBox.Text = "Folders transfered: ";
            // 
            // FilesTransferedTextBox
            // 
            this.FilesTransferedTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.FilesTransferedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FilesTransferedTextBox.Location = new System.Drawing.Point(7, 58);
            this.FilesTransferedTextBox.Name = "FilesTransferedTextBox";
            this.FilesTransferedTextBox.Size = new System.Drawing.Size(140, 13);
            this.FilesTransferedTextBox.TabIndex = 2;
            this.FilesTransferedTextBox.Text = "Files transfered: ";
            // 
            // FolderFailTextBox
            // 
            this.FolderFailTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.FolderFailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FolderFailTextBox.Location = new System.Drawing.Point(7, 39);
            this.FolderFailTextBox.Name = "FolderFailTextBox";
            this.FolderFailTextBox.Size = new System.Drawing.Size(140, 13);
            this.FolderFailTextBox.TabIndex = 1;
            this.FolderFailTextBox.Text = "Folders failed: ";
            // 
            // fileErrors
            // 
            this.fileErrors.Location = new System.Drawing.Point(396, 19);
            this.fileErrors.Name = "fileErrors";
            this.fileErrors.ReadOnly = true;
            this.fileErrors.Size = new System.Drawing.Size(384, 267);
            this.fileErrors.TabIndex = 1;
            this.fileErrors.Text = "";
            // 
            // filesTransfered
            // 
            this.filesTransfered.Location = new System.Drawing.Point(6, 19);
            this.filesTransfered.Name = "filesTransfered";
            this.filesTransfered.ReadOnly = true;
            this.filesTransfered.Size = new System.Drawing.Size(384, 267);
            this.filesTransfered.TabIndex = 0;
            this.filesTransfered.Text = "";
            // 
            // BrowseBox
            // 
            this.BrowseBox.Controls.Add(this.label1);
            this.BrowseBox.Controls.Add(this.SourceLabel);
            this.BrowseBox.Controls.Add(this.listBoxForDestination);
            this.BrowseBox.Controls.Add(this.listBoxForSource);
            this.BrowseBox.Location = new System.Drawing.Point(562, 12);
            this.BrowseBox.Name = "BrowseBox";
            this.BrowseBox.Size = new System.Drawing.Size(682, 256);
            this.BrowseBox.TabIndex = 2;
            this.BrowseBox.TabStop = false;
            this.BrowseBox.Text = "Browse";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(612, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 11);
            this.label1.TabIndex = 3;
            this.label1.Text = "Destination";
            // 
            // SourceLabel
            // 
            this.SourceLabel.BackColor = System.Drawing.Color.White;
            this.SourceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SourceLabel.Location = new System.Drawing.Point(276, 231);
            this.SourceLabel.Name = "SourceLabel";
            this.SourceLabel.Size = new System.Drawing.Size(47, 10);
            this.SourceLabel.TabIndex = 2;
            this.SourceLabel.Text = "Source";
            // 
            // listBoxForDestination
            // 
            this.listBoxForDestination.FormattingEnabled = true;
            this.listBoxForDestination.Location = new System.Drawing.Point(332, 19);
            this.listBoxForDestination.Name = "listBoxForDestination";
            this.listBoxForDestination.Size = new System.Drawing.Size(344, 225);
            this.listBoxForDestination.TabIndex = 1;
            this.listBoxForDestination.SelectedIndexChanged += new System.EventHandler(this.listBoxForDestination_SelectedIndexChanged);
            // 
            // listBoxForSource
            // 
            this.listBoxForSource.FormattingEnabled = true;
            this.listBoxForSource.Location = new System.Drawing.Point(6, 19);
            this.listBoxForSource.Name = "listBoxForSource";
            this.listBoxForSource.Size = new System.Drawing.Size(320, 225);
            this.listBoxForSource.TabIndex = 0;
            this.listBoxForSource.SelectedIndexChanged += new System.EventHandler(this.listBoxForSource_SelectedIndexChanged);
            // 
            // groupBoxForFilesinDir
            // 
            this.groupBoxForFilesinDir.Controls.Add(this.richTextBoxForFIieFoundinDir);
            this.groupBoxForFilesinDir.Location = new System.Drawing.Point(404, 12);
            this.groupBoxForFilesinDir.Name = "groupBoxForFilesinDir";
            this.groupBoxForFilesinDir.Size = new System.Drawing.Size(152, 256);
            this.groupBoxForFilesinDir.TabIndex = 3;
            this.groupBoxForFilesinDir.TabStop = false;
            this.groupBoxForFilesinDir.Text = "Files in directory";
            // 
            // richTextBoxForFIieFoundinDir
            // 
            this.richTextBoxForFIieFoundinDir.Location = new System.Drawing.Point(6, 19);
            this.richTextBoxForFIieFoundinDir.Name = "richTextBoxForFIieFoundinDir";
            this.richTextBoxForFIieFoundinDir.ReadOnly = true;
            this.richTextBoxForFIieFoundinDir.Size = new System.Drawing.Size(140, 225);
            this.richTextBoxForFIieFoundinDir.TabIndex = 6;
            this.richTextBoxForFIieFoundinDir.Text = "";
            // 
            // textBoxForDestination
            // 
            this.textBoxForDestination.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxForDestination.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxForDestination.Location = new System.Drawing.Point(6, 34);
            this.textBoxForDestination.Name = "textBoxForDestination";
            this.textBoxForDestination.Size = new System.Drawing.Size(368, 13);
            this.textBoxForDestination.TabIndex = 8;
            this.textBoxForDestination.Text = "Destination:";
            // 
            // textBoxForsrc
            // 
            this.textBoxForsrc.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxForsrc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxForsrc.Location = new System.Drawing.Point(6, 15);
            this.textBoxForsrc.Name = "textBoxForsrc";
            this.textBoxForsrc.Size = new System.Drawing.Size(368, 13);
            this.textBoxForsrc.TabIndex = 9;
            this.textBoxForsrc.Text = "Source:";
            // 
            // FilepathsBox
            // 
            this.FilepathsBox.Controls.Add(this.textBoxForsrc);
            this.FilepathsBox.Controls.Add(this.textBoxForDestination);
            this.FilepathsBox.Location = new System.Drawing.Point(18, 213);
            this.FilepathsBox.Name = "FilepathsBox";
            this.FilepathsBox.Size = new System.Drawing.Size(380, 55);
            this.FilepathsBox.TabIndex = 10;
            this.FilepathsBox.TabStop = false;
            this.FilepathsBox.Text = "File paths";
            // 
            // progressBarForTranfer
            // 
            this.progressBarForTranfer.BackColor = System.Drawing.SystemColors.Menu;
            this.progressBarForTranfer.Cursor = System.Windows.Forms.Cursors.No;
            this.progressBarForTranfer.ForeColor = System.Drawing.SystemColors.Control;
            this.progressBarForTranfer.Location = new System.Drawing.Point(786, 276);
            this.progressBarForTranfer.Name = "progressBarForTranfer";
            this.progressBarForTranfer.Size = new System.Drawing.Size(440, 10);
            this.progressBarForTranfer.TabIndex = 3;
            // 
            // progressBarForFolder
            // 
            this.progressBarForFolder.BackColor = System.Drawing.SystemColors.Menu;
            this.progressBarForFolder.Cursor = System.Windows.Forms.Cursors.No;
            this.progressBarForFolder.ForeColor = System.Drawing.SystemColors.Control;
            this.progressBarForFolder.Location = new System.Drawing.Point(786, 263);
            this.progressBarForFolder.Name = "progressBarForFolder";
            this.progressBarForFolder.Size = new System.Drawing.Size(440, 10);
            this.progressBarForFolder.TabIndex = 6;
            // 
            // FilesFailedTextBox
            // 
            this.FilesFailedTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.FilesFailedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FilesFailedTextBox.Location = new System.Drawing.Point(7, 20);
            this.FilesFailedTextBox.Name = "FilesFailedTextBox";
            this.FilesFailedTextBox.Size = new System.Drawing.Size(140, 13);
            this.FilesFailedTextBox.TabIndex = 0;
            this.FilesFailedTextBox.Text = "Files failed: ";
            // 
            // MyBox
            // 
            this.MyBox.BackColor = System.Drawing.SystemColors.Menu;
            this.MyBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MyBox.Location = new System.Drawing.Point(214, 12);
            this.MyBox.Name = "MyBox";
            this.MyBox.Size = new System.Drawing.Size(190, 13);
            this.MyBox.TabIndex = 8;
            this.MyBox.Text = "By: Avi 2022  The transfer system(TTS)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 569);
            this.Controls.Add(this.MyBox);
            this.Controls.Add(this.FilepathsBox);
            this.Controls.Add(this.groupBoxForFilesinDir);
            this.Controls.Add(this.BrowseBox);
            this.Controls.Add(this.LogBox);
            this.Controls.Add(this.fileTransferBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.fileTransferBox.ResumeLayout(false);
            this.fileTransferBox.PerformLayout();
            this.LogBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.StatusBox.ResumeLayout(false);
            this.StatusBox.PerformLayout();
            this.BrowseBox.ResumeLayout(false);
            this.groupBoxForFilesinDir.ResumeLayout(false);
            this.FilepathsBox.ResumeLayout(false);
            this.FilepathsBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox fileTransferBox;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBoxForDup;
        private System.Windows.Forms.CheckBox checkBoxSkipFiles;
        private System.Windows.Forms.CheckBox overWriteCheck;
        private System.Windows.Forms.GroupBox LogBox;
        private System.Windows.Forms.RichTextBox fileErrors;
        private System.Windows.Forms.RichTextBox filesTransfered;
        private System.Windows.Forms.GroupBox StatusBox;
        private System.Windows.Forms.TextBox FolderTransferedTextBox;
        private System.Windows.Forms.TextBox FilesTransferedTextBox;
        private System.Windows.Forms.TextBox FolderFailTextBox;
        private System.Windows.Forms.TextBox CountofFileTextbox;
        private System.Windows.Forms.TextBox CountofFolderTextbox;
        private System.Windows.Forms.TextBox FolderLeftToTransferTextBox;
        private System.Windows.Forms.TextBox FilesLeftToTransferTextBox;
        private System.Windows.Forms.GroupBox BrowseBox;
        private System.Windows.Forms.ListBox listBoxForDestination;
        private System.Windows.Forms.ListBox listBoxForSource;
        private System.Windows.Forms.RichTextBox richTextLogBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonTranfer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SourceLabel;
        private System.Windows.Forms.GroupBox groupBoxForFilesinDir;
        private System.Windows.Forms.RichTextBox richTextBoxForFIieFoundinDir;
        private System.Windows.Forms.TextBox textBoxForDestination;
        private System.Windows.Forms.TextBox textBoxForsrc;
        private System.Windows.Forms.GroupBox FilepathsBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.ProgressBar progressBarForFolder;
        private System.Windows.Forms.ProgressBar progressBarForTranfer;
        private System.Windows.Forms.TextBox FilesFailedTextBox;
        private System.Windows.Forms.TextBox MyBox;
    }
}

