﻿namespace WindowsFormsApp1.CAD_hardware
{
    partial class VideoSystemWork
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(76, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(319, 43);
            this.button1.TabIndex = 10;
            this.button1.Text = "Запросить системные параметры о видеосистеме";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Выберите одно из следующих действий";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(76, 140);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(319, 42);
            this.button2.TabIndex = 12;
            this.button2.Text = "Запросить параметры конфигурации системы (системную метрику)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(76, 198);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(319, 42);
            this.button3.TabIndex = 13;
            this.button3.Text = "Получить специфическую информацию о заданном устройстве";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(76, 256);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(319, 36);
            this.button4.TabIndex = 14;
            this.button4.Text = "Изменить размер монитора";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(76, 308);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(319, 77);
            this.button5.TabIndex = 15;
            this.button5.Text = "Выполнить передачу битовых блоков данных о цвете, соответствующих прямоугольнику " +
    "пикселей, из указанного контекста исходного устройства";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // VideoSystemWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(491, 421);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "VideoSystemWork";
            this.Text = "VideoSystemWork";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}