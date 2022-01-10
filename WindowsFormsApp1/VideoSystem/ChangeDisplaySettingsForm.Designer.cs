namespace WindowsFormsApp1.VideoSystem
{
    partial class ChangeDisplaySettingsForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.textHeight = new System.Windows.Forms.TextBox();
            this.buttonChangeDisplaySettings = new System.Windows.Forms.Button();
            this.textWidth = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "Напишите нужный Вам размер монитора";
            // 
            // textHeight
            // 
            this.textHeight.Location = new System.Drawing.Point(296, 58);
            this.textHeight.Multiline = true;
            this.textHeight.Name = "textHeight";
            this.textHeight.Size = new System.Drawing.Size(284, 31);
            this.textHeight.TabIndex = 30;
            // 
            // buttonChangeDisplaySettings
            // 
            this.buttonChangeDisplaySettings.Location = new System.Drawing.Point(204, 104);
            this.buttonChangeDisplaySettings.Name = "buttonChangeDisplaySettings";
            this.buttonChangeDisplaySettings.Size = new System.Drawing.Size(171, 26);
            this.buttonChangeDisplaySettings.TabIndex = 29;
            this.buttonChangeDisplaySettings.Text = "Применить";
            this.buttonChangeDisplaySettings.UseVisualStyleBackColor = true;
            this.buttonChangeDisplaySettings.Click += new System.EventHandler(this.buttonChangeDisplaySettings_Click);
            // 
            // textWidth
            // 
            this.textWidth.Location = new System.Drawing.Point(12, 58);
            this.textWidth.Multiline = true;
            this.textWidth.Name = "textWidth";
            this.textWidth.Size = new System.Drawing.Size(278, 31);
            this.textWidth.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 32;
            this.label1.Text = "Ширина";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(293, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 33;
            this.label3.Text = "Высота";
            // 
            // ChangeDisplaySettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(595, 145);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textHeight);
            this.Controls.Add(this.buttonChangeDisplaySettings);
            this.Controls.Add(this.textWidth);
            this.Name = "ChangeDisplaySettingsForm";
            this.Text = "ChangeDisplaySettingsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textHeight;
        private System.Windows.Forms.Button buttonChangeDisplaySettings;
        private System.Windows.Forms.TextBox textWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}