﻿namespace A360Archiver
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.treeView = new System.Windows.Forms.TreeView();
            this.treeImages = new System.Windows.Forms.ImageList(this.components);
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.btnClearList = new System.Windows.Forms.Button();
            this.btnRetry = new System.Windows.Forms.Button();
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnBackupFolder = new System.Windows.Forms.Button();
            this.tbxBackupFolder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ltvFiles = new System.Windows.Forms.ListView();
            this.chFilePath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.treeView);
            this.splitContainer.Panel1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer.Panel1MinSize = 100;
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.tableLayoutPanel);
            this.splitContainer.Panel2MinSize = 300;
            this.splitContainer.Size = new System.Drawing.Size(1136, 680);
            this.splitContainer.SplitterDistance = 355;
            this.splitContainer.SplitterWidth = 6;
            this.splitContainer.TabIndex = 0;
            // 
            // treeView
            // 
            this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView.ImageIndex = 0;
            this.treeView.ImageList = this.treeImages;
            this.treeView.Location = new System.Drawing.Point(4, 5);
            this.treeView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.treeView.Name = "treeView";
            this.treeView.SelectedImageIndex = 0;
            this.treeView.Size = new System.Drawing.Size(347, 670);
            this.treeView.TabIndex = 0;
            this.treeView.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView_BeforeExpand);
            // 
            // treeImages
            // 
            this.treeImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("treeImages.ImageStream")));
            this.treeImages.TransparentColor = System.Drawing.Color.Transparent;
            this.treeImages.Images.SetKeyName(0, "a360hub.png");
            this.treeImages.Images.SetKeyName(1, "a360project.png");
            this.treeImages.Images.SetKeyName(2, "folder_20x20.png");
            this.treeImages.Images.SetKeyName(3, "file_16x16.png");
            this.treeImages.Images.SetKeyName(4, "version_16x16.png");
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 6;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel.Controls.Add(this.btnClearList, 3, 2);
            this.tableLayoutPanel.Controls.Add(this.btnRetry, 2, 2);
            this.tableLayoutPanel.Controls.Add(this.btnBackup, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.btnBackupFolder, 5, 1);
            this.tableLayoutPanel.Controls.Add(this.tbxBackupFolder, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.ltvFiles, 0, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 3;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(775, 680);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // btnClearList
            // 
            this.btnClearList.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClearList.Location = new System.Drawing.Point(454, 637);
            this.btnClearList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClearList.Name = "btnClearList";
            this.btnClearList.Size = new System.Drawing.Size(142, 35);
            this.btnClearList.TabIndex = 6;
            this.btnClearList.Text = "Clear list";
            this.btnClearList.UseVisualStyleBackColor = true;
            this.btnClearList.Click += new System.EventHandler(this.btnClearList_Click);
            // 
            // btnRetry
            // 
            this.btnRetry.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRetry.Location = new System.Drawing.Point(304, 637);
            this.btnRetry.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRetry.Name = "btnRetry";
            this.btnRetry.Size = new System.Drawing.Size(142, 35);
            this.btnRetry.TabIndex = 5;
            this.btnRetry.Text = "Retry";
            this.btnRetry.UseVisualStyleBackColor = true;
            this.btnRetry.Click += new System.EventHandler(this.btnRetry_Click);
            // 
            // btnBackup
            // 
            this.btnBackup.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBackup.Location = new System.Drawing.Point(154, 637);
            this.btnBackup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(142, 35);
            this.btnBackup.TabIndex = 2;
            this.btnBackup.Text = "Start backup";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnBackupFolder
            // 
            this.btnBackupFolder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBackupFolder.Location = new System.Drawing.Point(733, 586);
            this.btnBackupFolder.Margin = new System.Windows.Forms.Padding(2, 2, 4, 2);
            this.btnBackupFolder.Name = "btnBackupFolder";
            this.btnBackupFolder.Size = new System.Drawing.Size(38, 35);
            this.btnBackupFolder.TabIndex = 3;
            this.btnBackupFolder.Text = "...";
            this.btnBackupFolder.UseVisualStyleBackColor = true;
            this.btnBackupFolder.Click += new System.EventHandler(this.btnBackupFolder_Click);
            // 
            // tbxBackupFolder
            // 
            this.tableLayoutPanel.SetColumnSpan(this.tbxBackupFolder, 4);
            this.tbxBackupFolder.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbxBackupFolder.Location = new System.Drawing.Point(154, 589);
            this.tbxBackupFolder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxBackupFolder.Name = "tbxBackupFolder";
            this.tbxBackupFolder.ReadOnly = true;
            this.tbxBackupFolder.Size = new System.Drawing.Size(573, 26);
            this.tbxBackupFolder.TabIndex = 1;
            this.tbxBackupFolder.Text = "C:\\temp\\A360";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(4, 584);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 9, 9, 0);
            this.label1.Size = new System.Drawing.Size(142, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Backup folder";
            // 
            // ltvFiles
            // 
            this.ltvFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chFilePath,
            this.chStatus});
            this.tableLayoutPanel.SetColumnSpan(this.ltvFiles, 6);
            this.ltvFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ltvFiles.FullRowSelect = true;
            this.ltvFiles.GridLines = true;
            this.ltvFiles.Location = new System.Drawing.Point(4, 5);
            this.ltvFiles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ltvFiles.Name = "ltvFiles";
            this.ltvFiles.Size = new System.Drawing.Size(767, 574);
            this.ltvFiles.TabIndex = 4;
            this.ltvFiles.UseCompatibleStateImageBehavior = false;
            this.ltvFiles.View = System.Windows.Forms.View.Details;
            // 
            // chFilePath
            // 
            this.chFilePath.Text = "File path";
            this.chFilePath.Width = 306;
            // 
            // chStatus
            // 
            this.chStatus.Text = "Status";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 680);
            this.Controls.Add(this.splitContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Fusion Backup";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.TextBox tbxBackupFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBackupFolder;
        private System.Windows.Forms.ListView ltvFiles;
        private System.Windows.Forms.ColumnHeader chFilePath;
        private System.Windows.Forms.ColumnHeader chStatus;
        private System.Windows.Forms.Button btnClearList;
        private System.Windows.Forms.Button btnRetry;
        private System.Windows.Forms.ImageList treeImages;
    }
}

