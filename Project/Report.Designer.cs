namespace Project
{
    partial class SendRepForm
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
            this.TB1 = new System.Windows.Forms.TextBox();
            this.TB2 = new System.Windows.Forms.TextBox();
            this.CB1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TB4 = new System.Windows.Forms.TextBox();
            this.TB3 = new System.Windows.Forms.TextBox();
            this.TB5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TB6 = new System.Windows.Forms.TextBox();
            this.TB7 = new System.Windows.Forms.TextBox();
            this.TB8 = new System.Windows.Forms.TextBox();
            this.TB9 = new System.Windows.Forms.TextBox();
            this.TB10 = new System.Windows.Forms.TextBox();
            this.TB11 = new System.Windows.Forms.TextBox();
            this.TB12 = new System.Windows.Forms.TextBox();
            this.TB13 = new System.Windows.Forms.TextBox();
            this.TB14 = new System.Windows.Forms.TextBox();
            this.TB15 = new System.Windows.Forms.TextBox();
            this.TB16 = new System.Windows.Forms.TextBox();
            this.TB17 = new System.Windows.Forms.TextBox();
            this.Send = new System.Windows.Forms.Button();
            this.MTB1 = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.MC1 = new System.Windows.Forms.MonthCalendar();
            this.CM_INN = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TB1
            // 
            this.TB1.Location = new System.Drawing.Point(141, 12);
            this.TB1.Name = "TB1";
            this.TB1.Size = new System.Drawing.Size(236, 20);
            this.TB1.TabIndex = 0;
            // 
            // TB2
            // 
            this.TB2.Location = new System.Drawing.Point(141, 48);
            this.TB2.Name = "TB2";
            this.TB2.Size = new System.Drawing.Size(121, 20);
            this.TB2.TabIndex = 1;
            // 
            // CB1
            // 
            this.CB1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB1.FormattingEnabled = true;
            this.CB1.Items.AddRange(new object[] {
            "Фонд Микрофинансирования",
            "Гарантийный фонд",
            "Центр кластерного развития",
            "Центр поддержки предпринимательства",
            "Центр экспорта"});
            this.CB1.Location = new System.Drawing.Point(141, 85);
            this.CB1.Name = "CB1";
            this.CB1.Size = new System.Drawing.Size(236, 21);
            this.CB1.TabIndex = 2;
            this.CB1.SelectionChangeCommitted += new System.EventHandler(this.ComboBox1_SelectionChangeCommitted);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TB4);
            this.groupBox1.Controls.Add(this.TB3);
            this.groupBox1.Controls.Add(this.TB5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(101, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 119);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры KPI";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(230, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "шт.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(230, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "чел.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Созданные рабочие места:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Численность сотрудников:";
            // 
            // TB4
            // 
            this.TB4.Location = new System.Drawing.Point(170, 58);
            this.TB4.Name = "TB4";
            this.TB4.Size = new System.Drawing.Size(58, 20);
            this.TB4.TabIndex = 1;
            // 
            // TB3
            // 
            this.TB3.Location = new System.Drawing.Point(170, 29);
            this.TB3.Name = "TB3";
            this.TB3.Size = new System.Drawing.Size(58, 20);
            this.TB3.TabIndex = 0;
            // 
            // TB5
            // 
            this.TB5.Location = new System.Drawing.Point(170, 84);
            this.TB5.Name = "TB5";
            this.TB5.Size = new System.Drawing.Size(58, 20);
            this.TB5.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(111, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Выручка:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(230, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "млн.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Название организации:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "ИНН:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Институт поддержки:";
            // 
            // TB6
            // 
            this.TB6.Location = new System.Drawing.Point(383, 157);
            this.TB6.Name = "TB6";
            this.TB6.Size = new System.Drawing.Size(58, 20);
            this.TB6.TabIndex = 7;
            // 
            // TB7
            // 
            this.TB7.Location = new System.Drawing.Point(383, 186);
            this.TB7.Name = "TB7";
            this.TB7.Size = new System.Drawing.Size(58, 20);
            this.TB7.TabIndex = 8;
            // 
            // TB8
            // 
            this.TB8.Location = new System.Drawing.Point(383, 212);
            this.TB8.Name = "TB8";
            this.TB8.Size = new System.Drawing.Size(58, 20);
            this.TB8.TabIndex = 9;
            // 
            // TB9
            // 
            this.TB9.Location = new System.Drawing.Point(447, 157);
            this.TB9.Name = "TB9";
            this.TB9.Size = new System.Drawing.Size(58, 20);
            this.TB9.TabIndex = 10;
            // 
            // TB10
            // 
            this.TB10.Location = new System.Drawing.Point(447, 186);
            this.TB10.Name = "TB10";
            this.TB10.Size = new System.Drawing.Size(58, 20);
            this.TB10.TabIndex = 11;
            // 
            // TB11
            // 
            this.TB11.Location = new System.Drawing.Point(447, 212);
            this.TB11.Name = "TB11";
            this.TB11.Size = new System.Drawing.Size(58, 20);
            this.TB11.TabIndex = 12;
            // 
            // TB12
            // 
            this.TB12.Location = new System.Drawing.Point(511, 157);
            this.TB12.Name = "TB12";
            this.TB12.Size = new System.Drawing.Size(58, 20);
            this.TB12.TabIndex = 13;
            // 
            // TB13
            // 
            this.TB13.Location = new System.Drawing.Point(511, 186);
            this.TB13.Name = "TB13";
            this.TB13.Size = new System.Drawing.Size(58, 20);
            this.TB13.TabIndex = 14;
            // 
            // TB14
            // 
            this.TB14.Location = new System.Drawing.Point(511, 212);
            this.TB14.Name = "TB14";
            this.TB14.Size = new System.Drawing.Size(58, 20);
            this.TB14.TabIndex = 15;
            // 
            // TB15
            // 
            this.TB15.Location = new System.Drawing.Point(575, 157);
            this.TB15.Name = "TB15";
            this.TB15.Size = new System.Drawing.Size(58, 20);
            this.TB15.TabIndex = 16;
            // 
            // TB16
            // 
            this.TB16.Location = new System.Drawing.Point(575, 186);
            this.TB16.Name = "TB16";
            this.TB16.Size = new System.Drawing.Size(58, 20);
            this.TB16.TabIndex = 17;
            // 
            // TB17
            // 
            this.TB17.Location = new System.Drawing.Point(575, 212);
            this.TB17.Name = "TB17";
            this.TB17.Size = new System.Drawing.Size(58, 20);
            this.TB17.TabIndex = 18;
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(47, 363);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(82, 23);
            this.Send.TabIndex = 19;
            this.Send.Text = "Отправить";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // MTB1
            // 
            this.MTB1.Location = new System.Drawing.Point(141, 263);
            this.MTB1.Mask = "00/00/0000";
            this.MTB1.Name = "MTB1";
            this.MTB1.Size = new System.Drawing.Size(65, 20);
            this.MTB1.TabIndex = 20;
            this.MTB1.ValidatingType = typeof(System.DateTime);
            this.MTB1.Click += new System.EventHandler(this.MTB1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(66, 266);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Дата отчета:";
            // 
            // MC1
            // 
            this.MC1.Location = new System.Drawing.Point(213, 237);
            this.MC1.Name = "MC1";
            this.MC1.TabIndex = 22;
            this.MC1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.MC1_DateSelected);
            // 
            // CM_INN
            // 
            this.CM_INN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CM_INN.FormattingEnabled = true;
            this.CM_INN.Location = new System.Drawing.Point(268, 48);
            this.CM_INN.Name = "CM_INN";
            this.CM_INN.Size = new System.Drawing.Size(122, 21);
            this.CM_INN.TabIndex = 23;
            // 
            // SendRepForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(643, 432);
            this.Controls.Add(this.CM_INN);
            this.Controls.Add(this.MC1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.MTB1);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.TB17);
            this.Controls.Add(this.TB16);
            this.Controls.Add(this.TB15);
            this.Controls.Add(this.TB14);
            this.Controls.Add(this.TB13);
            this.Controls.Add(this.TB12);
            this.Controls.Add(this.TB11);
            this.Controls.Add(this.TB10);
            this.Controls.Add(this.TB9);
            this.Controls.Add(this.TB8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB6);
            this.Controls.Add(this.CB1);
            this.Controls.Add(this.TB2);
            this.Controls.Add(this.TB1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "SendRepForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.SendRepForm_Load);
            this.Click += new System.EventHandler(this.SendRepForm_Click);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB1;
        private System.Windows.Forms.TextBox TB2;
        private System.Windows.Forms.ComboBox CB1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TB5;
        private System.Windows.Forms.TextBox TB4;
        private System.Windows.Forms.TextBox TB3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TB6;
        private System.Windows.Forms.TextBox TB7;
        private System.Windows.Forms.TextBox TB8;
        private System.Windows.Forms.TextBox TB9;
        private System.Windows.Forms.TextBox TB10;
        private System.Windows.Forms.TextBox TB11;
        private System.Windows.Forms.TextBox TB12;
        private System.Windows.Forms.TextBox TB13;
        private System.Windows.Forms.TextBox TB14;
        private System.Windows.Forms.TextBox TB15;
        private System.Windows.Forms.TextBox TB16;
        private System.Windows.Forms.TextBox TB17;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.MaskedTextBox MTB1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MonthCalendar MC1;
        private System.Windows.Forms.ComboBox CM_INN;
    }
}