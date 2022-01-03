namespace WindowsFormsApp1.CAD_hardware
{
    partial class ManualInputDeviceWork
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
            this.buttonGetKeyboardType = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(52, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Выберите одно из следующих действий";
            // 
            // buttonGetKeyboardType
            // 
            this.buttonGetKeyboardType.Location = new System.Drawing.Point(86, 78);
            this.buttonGetKeyboardType.Name = "buttonGetKeyboardType";
            this.buttonGetKeyboardType.Size = new System.Drawing.Size(319, 36);
            this.buttonGetKeyboardType.TabIndex = 7;
            this.buttonGetKeyboardType.Text = "Извлечь информацию о текущей клавиатуре";
            this.buttonGetKeyboardType.UseVisualStyleBackColor = true;
            this.buttonGetKeyboardType.Click += new System.EventHandler(this.buttonGetKeyboardType_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(86, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(319, 44);
            this.button1.TabIndex = 8;
            this.button1.Text = "Посмотреть, нажата ли клавиша на клавиатуре";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(86, 189);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(319, 43);
            this.button2.TabIndex = 9;
            this.button2.Text = "Запросить системные параметры";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(86, 247);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(319, 44);
            this.button3.TabIndex = 10;
            this.button3.Text = "Изменить или восстанавить значения левой и правой кнопок мыши";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(86, 306);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(319, 43);
            this.button4.TabIndex = 11;
            this.button4.Text = "Ограничить курсор прямоугольной областью на экране";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(86, 365);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(319, 44);
            this.button5.TabIndex = 12;
            this.button5.Text = "Перемещение курсора к указанным координатам экрана";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // ManualInputDeviceWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(516, 465);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonGetKeyboardType);
            this.Controls.Add(this.label1);
            this.Name = "ManualInputDeviceWork";
            this.Text = "ManualInputDeviceWork";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonGetKeyboardType;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}