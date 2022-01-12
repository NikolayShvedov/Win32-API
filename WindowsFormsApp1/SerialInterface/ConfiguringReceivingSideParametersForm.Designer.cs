namespace WindowsFormsApp1.SerialInterface
{
    partial class ConfiguringReceivingSideParametersForm
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
            this.groupBoxB = new System.Windows.Forms.GroupBox();
            this.portButtonB = new System.Windows.Forms.Button();
            this.stopBoxB = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.parityBoxB = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.recvTextB = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comBoxB = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.baudBoxB = new System.Windows.Forms.ComboBox();
            this.msgBoxB = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.sendButtonB = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBoxA = new System.Windows.Forms.GroupBox();
            this.portButtonA = new System.Windows.Forms.Button();
            this.stopBoxA = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.parityBoxA = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.recvTextA = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comBoxA = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.baudBoxA = new System.Windows.Forms.ComboBox();
            this.msgBoxA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sendButtonA = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxB.SuspendLayout();
            this.groupBoxA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxB
            // 
            this.groupBoxB.Controls.Add(this.portButtonB);
            this.groupBoxB.Controls.Add(this.stopBoxB);
            this.groupBoxB.Controls.Add(this.label5);
            this.groupBoxB.Controls.Add(this.parityBoxB);
            this.groupBoxB.Controls.Add(this.label8);
            this.groupBoxB.Controls.Add(this.recvTextB);
            this.groupBoxB.Controls.Add(this.label10);
            this.groupBoxB.Controls.Add(this.comBoxB);
            this.groupBoxB.Controls.Add(this.label11);
            this.groupBoxB.Controls.Add(this.baudBoxB);
            this.groupBoxB.Controls.Add(this.msgBoxB);
            this.groupBoxB.Controls.Add(this.label12);
            this.groupBoxB.Controls.Add(this.sendButtonB);
            this.groupBoxB.Controls.Add(this.label13);
            this.groupBoxB.Location = new System.Drawing.Point(13, 236);
            this.groupBoxB.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxB.Name = "groupBoxB";
            this.groupBoxB.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxB.Size = new System.Drawing.Size(480, 215);
            this.groupBoxB.TabIndex = 5;
            this.groupBoxB.TabStop = false;
            this.groupBoxB.Text = "Port B";
            // 
            // portButtonB
            // 
            this.portButtonB.Location = new System.Drawing.Point(348, 108);
            this.portButtonB.Margin = new System.Windows.Forms.Padding(4);
            this.portButtonB.Name = "portButtonB";
            this.portButtonB.Size = new System.Drawing.Size(124, 28);
            this.portButtonB.TabIndex = 12;
            this.portButtonB.Text = "Connect";
            this.portButtonB.UseVisualStyleBackColor = true;
            this.portButtonB.Click += new System.EventHandler(this.portButtonB_Click);
            // 
            // stopBoxB
            // 
            this.stopBoxB.FormattingEnabled = true;
            this.stopBoxB.Location = new System.Drawing.Point(120, 116);
            this.stopBoxB.Margin = new System.Windows.Forms.Padding(4);
            this.stopBoxB.Name = "stopBoxB";
            this.stopBoxB.Size = new System.Drawing.Size(160, 24);
            this.stopBoxB.Sorted = true;
            this.stopBoxB.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 119);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Стоповый бит:";
            // 
            // parityBoxB
            // 
            this.parityBoxB.FormattingEnabled = true;
            this.parityBoxB.Location = new System.Drawing.Point(87, 82);
            this.parityBoxB.Margin = new System.Windows.Forms.Padding(4);
            this.parityBoxB.Name = "parityBoxB";
            this.parityBoxB.Size = new System.Drawing.Size(160, 24);
            this.parityBoxB.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 86);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Паритет:";
            // 
            // recvTextB
            // 
            this.recvTextB.AutoSize = true;
            this.recvTextB.Location = new System.Drawing.Point(91, 187);
            this.recvTextB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.recvTextB.Name = "recvTextB";
            this.recvTextB.Size = new System.Drawing.Size(0, 17);
            this.recvTextB.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 187);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 17);
            this.label10.TabIndex = 3;
            this.label10.Text = "Получено:";
            // 
            // comBoxB
            // 
            this.comBoxB.FormattingEnabled = true;
            this.comBoxB.Location = new System.Drawing.Point(87, 16);
            this.comBoxB.Margin = new System.Windows.Forms.Padding(4);
            this.comBoxB.Name = "comBoxB";
            this.comBoxB.Size = new System.Drawing.Size(160, 24);
            this.comBoxB.Sorted = true;
            this.comBoxB.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 20);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 17);
            this.label11.TabIndex = 5;
            this.label11.Text = "Com порт:";
            // 
            // baudBoxB
            // 
            this.baudBoxB.FormattingEnabled = true;
            this.baudBoxB.Location = new System.Drawing.Point(209, 50);
            this.baudBoxB.Margin = new System.Windows.Forms.Padding(4);
            this.baudBoxB.Name = "baudBoxB";
            this.baudBoxB.Size = new System.Drawing.Size(160, 24);
            this.baudBoxB.TabIndex = 4;
            // 
            // msgBoxB
            // 
            this.msgBoxB.Location = new System.Drawing.Point(94, 150);
            this.msgBoxB.Margin = new System.Windows.Forms.Padding(4);
            this.msgBoxB.Name = "msgBoxB";
            this.msgBoxB.Size = new System.Drawing.Size(248, 22);
            this.msgBoxB.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 53);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(193, 17);
            this.label12.TabIndex = 1;
            this.label12.Text = "Скорость передачи данных:";
            // 
            // sendButtonB
            // 
            this.sendButtonB.Location = new System.Drawing.Point(351, 145);
            this.sendButtonB.Margin = new System.Windows.Forms.Padding(4);
            this.sendButtonB.Name = "sendButtonB";
            this.sendButtonB.Size = new System.Drawing.Size(121, 28);
            this.sendButtonB.TabIndex = 2;
            this.sendButtonB.Text = "Send Message";
            this.sendButtonB.UseVisualStyleBackColor = true;
            this.sendButtonB.Click += new System.EventHandler(this.sendButtonB_Click_1);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 153);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 17);
            this.label13.TabIndex = 0;
            this.label13.Text = "Сообщение:";
            // 
            // groupBoxA
            // 
            this.groupBoxA.Controls.Add(this.portButtonA);
            this.groupBoxA.Controls.Add(this.stopBoxA);
            this.groupBoxA.Controls.Add(this.label7);
            this.groupBoxA.Controls.Add(this.parityBoxA);
            this.groupBoxA.Controls.Add(this.label6);
            this.groupBoxA.Controls.Add(this.recvTextA);
            this.groupBoxA.Controls.Add(this.label4);
            this.groupBoxA.Controls.Add(this.comBoxA);
            this.groupBoxA.Controls.Add(this.label3);
            this.groupBoxA.Controls.Add(this.baudBoxA);
            this.groupBoxA.Controls.Add(this.msgBoxA);
            this.groupBoxA.Controls.Add(this.label2);
            this.groupBoxA.Controls.Add(this.sendButtonA);
            this.groupBoxA.Controls.Add(this.label1);
            this.groupBoxA.Location = new System.Drawing.Point(13, 13);
            this.groupBoxA.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxA.Name = "groupBoxA";
            this.groupBoxA.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxA.Size = new System.Drawing.Size(480, 215);
            this.groupBoxA.TabIndex = 4;
            this.groupBoxA.TabStop = false;
            this.groupBoxA.Text = "Port A";
            // 
            // portButtonA
            // 
            this.portButtonA.Location = new System.Drawing.Point(351, 109);
            this.portButtonA.Margin = new System.Windows.Forms.Padding(4);
            this.portButtonA.Name = "portButtonA";
            this.portButtonA.Size = new System.Drawing.Size(121, 28);
            this.portButtonA.TabIndex = 13;
            this.portButtonA.Text = "Connect";
            this.portButtonA.UseVisualStyleBackColor = true;
            this.portButtonA.Click += new System.EventHandler(this.portButtonA_Click);
            // 
            // stopBoxA
            // 
            this.stopBoxA.FormattingEnabled = true;
            this.stopBoxA.Location = new System.Drawing.Point(120, 116);
            this.stopBoxA.Margin = new System.Windows.Forms.Padding(4);
            this.stopBoxA.Name = "stopBoxA";
            this.stopBoxA.Size = new System.Drawing.Size(160, 24);
            this.stopBoxA.Sorted = true;
            this.stopBoxA.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 119);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Стоповый бит:";
            // 
            // parityBoxA
            // 
            this.parityBoxA.FormattingEnabled = true;
            this.parityBoxA.Location = new System.Drawing.Point(84, 83);
            this.parityBoxA.Margin = new System.Windows.Forms.Padding(4);
            this.parityBoxA.Name = "parityBoxA";
            this.parityBoxA.Size = new System.Drawing.Size(160, 24);
            this.parityBoxA.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 86);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Паритет:";
            // 
            // recvTextA
            // 
            this.recvTextA.AutoSize = true;
            this.recvTextA.Location = new System.Drawing.Point(91, 187);
            this.recvTextA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.recvTextA.Name = "recvTextA";
            this.recvTextA.Size = new System.Drawing.Size(0, 17);
            this.recvTextA.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 187);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Получено:";
            // 
            // comBoxA
            // 
            this.comBoxA.FormattingEnabled = true;
            this.comBoxA.Location = new System.Drawing.Point(87, 16);
            this.comBoxA.Margin = new System.Windows.Forms.Padding(4);
            this.comBoxA.Name = "comBoxA";
            this.comBoxA.Size = new System.Drawing.Size(160, 24);
            this.comBoxA.Sorted = true;
            this.comBoxA.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Com порт:";
            // 
            // baudBoxA
            // 
            this.baudBoxA.FormattingEnabled = true;
            this.baudBoxA.Location = new System.Drawing.Point(209, 48);
            this.baudBoxA.Margin = new System.Windows.Forms.Padding(4);
            this.baudBoxA.Name = "baudBoxA";
            this.baudBoxA.Size = new System.Drawing.Size(160, 24);
            this.baudBoxA.TabIndex = 4;
            // 
            // msgBoxA
            // 
            this.msgBoxA.Location = new System.Drawing.Point(94, 150);
            this.msgBoxA.Margin = new System.Windows.Forms.Padding(4);
            this.msgBoxA.Name = "msgBoxA";
            this.msgBoxA.Size = new System.Drawing.Size(248, 22);
            this.msgBoxA.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Скорость передачи данных:";
            // 
            // sendButtonA
            // 
            this.sendButtonA.Location = new System.Drawing.Point(351, 145);
            this.sendButtonA.Margin = new System.Windows.Forms.Padding(4);
            this.sendButtonA.Name = "sendButtonA";
            this.sendButtonA.Size = new System.Drawing.Size(121, 28);
            this.sendButtonA.TabIndex = 2;
            this.sendButtonA.Text = "Send Message";
            this.sendButtonA.UseVisualStyleBackColor = true;
            this.sendButtonA.Click += new System.EventHandler(this.sendButtonA_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 153);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сообщение:";
            // 
            // ConfiguringReceivingSideParametersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 462);
            this.Controls.Add(this.groupBoxB);
            this.Controls.Add(this.groupBoxA);
            this.Name = "ConfiguringReceivingSideParametersForm";
            this.Text = "ConfiguringReceivingSideParametersForm";
            this.Load += new System.EventHandler(this.ConfiguringReceivingSideParametersForm_Load);
            this.groupBoxB.ResumeLayout(false);
            this.groupBoxB.PerformLayout();
            this.groupBoxA.ResumeLayout(false);
            this.groupBoxA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxB;
        private System.Windows.Forms.Button portButtonB;
        private System.Windows.Forms.ComboBox stopBoxB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox parityBoxB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label recvTextB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comBoxB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox baudBoxB;
        private System.Windows.Forms.TextBox msgBoxB;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button sendButtonB;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBoxA;
        private System.Windows.Forms.Button portButtonA;
        private System.Windows.Forms.ComboBox stopBoxA;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox parityBoxA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label recvTextA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comBoxA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox baudBoxA;
        private System.Windows.Forms.TextBox msgBoxA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button sendButtonA;
        private System.Windows.Forms.Label label1;
    }
}