namespace WindowsFormsApp1
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
            this.buttonFileSystemWork = new System.Windows.Forms.Button();
            this.buttonManualInputDeviceWork = new System.Windows.Forms.Button();
            this.buttonVideoSystemWork = new System.Windows.Forms.Button();
            this.buttonPrinterWork = new System.Windows.Forms.Button();
            this.buttonSerialInterfaceWork = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonFileSystemWork
            // 
            this.buttonFileSystemWork.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonFileSystemWork.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonFileSystemWork.Location = new System.Drawing.Point(104, 95);
            this.buttonFileSystemWork.Name = "buttonFileSystemWork";
            this.buttonFileSystemWork.Size = new System.Drawing.Size(382, 41);
            this.buttonFileSystemWork.TabIndex = 0;
            this.buttonFileSystemWork.Text = "Работа с дисковой и файловой системой";
            this.buttonFileSystemWork.UseVisualStyleBackColor = false;
            this.buttonFileSystemWork.Click += new System.EventHandler(this.buttonFileSystemWork_Click);
            // 
            // buttonManualInputDeviceWork
            // 
            this.buttonManualInputDeviceWork.BackColor = System.Drawing.Color.Chocolate;
            this.buttonManualInputDeviceWork.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonManualInputDeviceWork.Location = new System.Drawing.Point(104, 142);
            this.buttonManualInputDeviceWork.Name = "buttonManualInputDeviceWork";
            this.buttonManualInputDeviceWork.Size = new System.Drawing.Size(382, 37);
            this.buttonManualInputDeviceWork.TabIndex = 1;
            this.buttonManualInputDeviceWork.Text = "Работа с устройствами ручного ввода";
            this.buttonManualInputDeviceWork.UseVisualStyleBackColor = false;
            this.buttonManualInputDeviceWork.Click += new System.EventHandler(this.buttonManualInputDeviceWork_Click);
            // 
            // buttonVideoSystemWork
            // 
            this.buttonVideoSystemWork.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonVideoSystemWork.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonVideoSystemWork.Location = new System.Drawing.Point(104, 185);
            this.buttonVideoSystemWork.Name = "buttonVideoSystemWork";
            this.buttonVideoSystemWork.Size = new System.Drawing.Size(382, 39);
            this.buttonVideoSystemWork.TabIndex = 2;
            this.buttonVideoSystemWork.Text = "Работа с видеосистемой";
            this.buttonVideoSystemWork.UseVisualStyleBackColor = false;
            this.buttonVideoSystemWork.Click += new System.EventHandler(this.buttonVideoSystemWork_Click);
            // 
            // buttonPrinterWork
            // 
            this.buttonPrinterWork.BackColor = System.Drawing.Color.Indigo;
            this.buttonPrinterWork.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonPrinterWork.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonPrinterWork.Location = new System.Drawing.Point(104, 230);
            this.buttonPrinterWork.Name = "buttonPrinterWork";
            this.buttonPrinterWork.Size = new System.Drawing.Size(382, 39);
            this.buttonPrinterWork.TabIndex = 3;
            this.buttonPrinterWork.Text = "Организаци связи с принтером";
            this.buttonPrinterWork.UseVisualStyleBackColor = false;
            this.buttonPrinterWork.Click += new System.EventHandler(this.buttonPrinterWork_Click);
            // 
            // buttonSerialInterfaceWork
            // 
            this.buttonSerialInterfaceWork.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonSerialInterfaceWork.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSerialInterfaceWork.Location = new System.Drawing.Point(104, 275);
            this.buttonSerialInterfaceWork.Name = "buttonSerialInterfaceWork";
            this.buttonSerialInterfaceWork.Size = new System.Drawing.Size(382, 52);
            this.buttonSerialInterfaceWork.TabIndex = 4;
            this.buttonSerialInterfaceWork.Text = "Организация связи по последовательному интерфейсу";
            this.buttonSerialInterfaceWork.UseVisualStyleBackColor = false;
            this.buttonSerialInterfaceWork.Click += new System.EventHandler(this.buttonSerialInterfaceWork_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(518, 360);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(581, 43);
            this.label1.TabIndex = 7;
            this.label1.Text = "Данное программное средство написано для информационного взаимодействия техническ" +
    "их средств САПР";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(605, 393);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonSerialInterfaceWork);
            this.Controls.Add(this.buttonPrinterWork);
            this.Controls.Add(this.buttonVideoSystemWork);
            this.Controls.Add(this.buttonManualInputDeviceWork);
            this.Controls.Add(this.buttonFileSystemWork);
            this.Name = "Form1";
            this.Text = "Информационное взаимодействие ТС САПР";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonFileSystemWork;
        private System.Windows.Forms.Button buttonManualInputDeviceWork;
        private System.Windows.Forms.Button buttonVideoSystemWork;
        private System.Windows.Forms.Button buttonPrinterWork;
        private System.Windows.Forms.Button buttonSerialInterfaceWork;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label1;
    }
}

