﻿namespace WindowsFormsApp1.CAD_hardware
{
    partial class FileSystemWork
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
            this.buttonLogicalDrives = new System.Windows.Forms.Button();
            this.buttonDiskFreeSpace = new System.Windows.Forms.Button();
            this.buttonFindFirstFile = new System.Windows.Forms.Button();
            this.buttonCreateDirectory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonLogicalDrives
            // 
            this.buttonLogicalDrives.Location = new System.Drawing.Point(66, 88);
            this.buttonLogicalDrives.Name = "buttonLogicalDrives";
            this.buttonLogicalDrives.Size = new System.Drawing.Size(265, 48);
            this.buttonLogicalDrives.TabIndex = 0;
            this.buttonLogicalDrives.Text = "Посмотреть имена логических дисков данного компьютера";
            this.buttonLogicalDrives.UseVisualStyleBackColor = true;
            this.buttonLogicalDrives.Click += new System.EventHandler(this.buttonLogicalDrives_Click);
            // 
            // buttonDiskFreeSpace
            // 
            this.buttonDiskFreeSpace.Location = new System.Drawing.Point(66, 151);
            this.buttonDiskFreeSpace.Name = "buttonDiskFreeSpace";
            this.buttonDiskFreeSpace.Size = new System.Drawing.Size(265, 61);
            this.buttonDiskFreeSpace.TabIndex = 1;
            this.buttonDiskFreeSpace.Text = "Посмотреть объем свободного места  логических дисков в байтах данного компьютера";
            this.buttonDiskFreeSpace.UseVisualStyleBackColor = true;
            this.buttonDiskFreeSpace.Click += new System.EventHandler(this.buttonDiskFreeSpace_Click);
            // 
            // buttonFindFirstFile
            // 
            this.buttonFindFirstFile.Location = new System.Drawing.Point(66, 229);
            this.buttonFindFirstFile.Name = "buttonFindFirstFile";
            this.buttonFindFirstFile.Size = new System.Drawing.Size(265, 45);
            this.buttonFindFirstFile.TabIndex = 2;
            this.buttonFindFirstFile.Text = "Производить поиск первого файла, соответствующего маске поиска";
            this.buttonFindFirstFile.UseVisualStyleBackColor = true;
            this.buttonFindFirstFile.Click += new System.EventHandler(this.buttonFindFirstFile_Click);
            // 
            // buttonCreateDirectory
            // 
            this.buttonCreateDirectory.Location = new System.Drawing.Point(66, 290);
            this.buttonCreateDirectory.Name = "buttonCreateDirectory";
            this.buttonCreateDirectory.Size = new System.Drawing.Size(265, 32);
            this.buttonCreateDirectory.TabIndex = 3;
            this.buttonCreateDirectory.Text = "Создать каталог по заданному пути";
            this.buttonCreateDirectory.UseVisualStyleBackColor = true;
            this.buttonCreateDirectory.Click += new System.EventHandler(this.buttonCreateDirectory_Click);
            // 
            // FileSystemWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(405, 421);
            this.Controls.Add(this.buttonCreateDirectory);
            this.Controls.Add(this.buttonFindFirstFile);
            this.Controls.Add(this.buttonDiskFreeSpace);
            this.Controls.Add(this.buttonLogicalDrives);
            this.Name = "FileSystemWork";
            this.Text = "FileSystemWork";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLogicalDrives;
        private System.Windows.Forms.Button buttonDiskFreeSpace;
        private System.Windows.Forms.Button buttonFindFirstFile;
        private System.Windows.Forms.Button buttonCreateDirectory;
    }
}