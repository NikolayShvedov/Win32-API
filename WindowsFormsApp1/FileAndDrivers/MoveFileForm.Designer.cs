namespace WindowsFormsApp1.FileAndDrivers
{
    partial class MoveFileForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textNewPathFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonMove = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textPathFile = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(293, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(303, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Новый путь к файлу (обяз. название файла)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Путь к файлу (обяз. название файла)";
            // 
            // textNewPathFile
            // 
            this.textNewPathFile.Location = new System.Drawing.Point(296, 92);
            this.textNewPathFile.Multiline = true;
            this.textNewPathFile.Name = "textNewPathFile";
            this.textNewPathFile.Size = new System.Drawing.Size(284, 43);
            this.textNewPathFile.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(713, 44);
            this.label1.TabIndex = 24;
            this.label1.Text = "Переместить файл в новое местоположение";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonMove
            // 
            this.buttonMove.Location = new System.Drawing.Point(590, 92);
            this.buttonMove.Name = "buttonMove";
            this.buttonMove.Size = new System.Drawing.Size(111, 43);
            this.buttonMove.TabIndex = 23;
            this.buttonMove.Text = "Переместить";
            this.buttonMove.UseVisualStyleBackColor = true;
            this.buttonMove.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 145);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(689, 260);
            this.listBox1.TabIndex = 22;
            // 
            // textPathFile
            // 
            this.textPathFile.Location = new System.Drawing.Point(12, 92);
            this.textPathFile.Multiline = true;
            this.textPathFile.Name = "textPathFile";
            this.textPathFile.Size = new System.Drawing.Size(278, 43);
            this.textPathFile.TabIndex = 21;
            // 
            // MoveFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(713, 416);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textNewPathFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonMove);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textPathFile);
            this.Name = "MoveFileForm";
            this.Text = "MoveFileForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textNewPathFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonMove;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textPathFile;
    }
}