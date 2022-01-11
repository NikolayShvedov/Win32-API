namespace WindowsFormsApp1.Printer
{
    partial class WriteFileForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.wordExportButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(456, 24);
            this.label1.TabIndex = 23;
            this.label1.Text = "Введите текст для экспорта в файл MS Word";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 42);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(594, 263);
            this.textBox1.TabIndex = 22;
            // 
            // wordExportButton
            // 
            this.wordExportButton.BackColor = System.Drawing.Color.Blue;
            this.wordExportButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.wordExportButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumTurquoise;
            this.wordExportButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.wordExportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wordExportButton.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wordExportButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.wordExportButton.Location = new System.Drawing.Point(386, 312);
            this.wordExportButton.Margin = new System.Windows.Forms.Padding(4);
            this.wordExportButton.Name = "wordExportButton";
            this.wordExportButton.Size = new System.Drawing.Size(220, 39);
            this.wordExportButton.TabIndex = 87;
            this.wordExportButton.Text = "Экспорт в Word";
            this.wordExportButton.UseVisualStyleBackColor = false;
            this.wordExportButton.Click += new System.EventHandler(this.wordExportButton_Click);
            // 
            // WriteFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(619, 360);
            this.Controls.Add(this.wordExportButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "WriteFileForm";
            this.Text = "WriteFileForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button wordExportButton;
    }
}