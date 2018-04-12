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
            this.CB1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TBFM2 = new System.Windows.Forms.TextBox();
            this.TBFM1 = new System.Windows.Forms.TextBox();
            this.TBFM3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TBCE3 = new System.Windows.Forms.TextBox();
            this.TBCE2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TBCE1 = new System.Windows.Forms.TextBox();
            this.TBGF1 = new System.Windows.Forms.TextBox();
            this.TBGF3 = new System.Windows.Forms.TextBox();
            this.TBCPP3 = new System.Windows.Forms.TextBox();
            this.TBCPP2 = new System.Windows.Forms.TextBox();
            this.TBGF2 = new System.Windows.Forms.TextBox();
            this.TBCPP1 = new System.Windows.Forms.TextBox();
            this.TBCKR3 = new System.Windows.Forms.TextBox();
            this.TBCKR1 = new System.Windows.Forms.TextBox();
            this.TBCKR2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Send = new System.Windows.Forms.Button();
            this.MTB1 = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.MC1 = new System.Windows.Forms.MonthCalendar();
            this.CB_INN = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TBcompName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.CB1.Location = new System.Drawing.Point(222, 93);
            this.CB1.Name = "CB1";
            this.CB1.Size = new System.Drawing.Size(238, 21);
            this.CB1.TabIndex = 2;
            this.CB1.SelectionChangeCommitted += new System.EventHandler(this.ComboBox1_SelectionChangeCommitted);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TBCPP3);
            this.groupBox1.Controls.Add(this.TBCPP1);
            this.groupBox1.Controls.Add(this.TBCE3);
            this.groupBox1.Controls.Add(this.TBCPP2);
            this.groupBox1.Controls.Add(this.TBGF3);
            this.groupBox1.Controls.Add(this.TBGF2);
            this.groupBox1.Controls.Add(this.TBFM3);
            this.groupBox1.Controls.Add(this.TBGF1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.TBCKR3);
            this.groupBox1.Controls.Add(this.TBCKR1);
            this.groupBox1.Controls.Add(this.TBCKR2);
            this.groupBox1.Controls.Add(this.TBCE2);
            this.groupBox1.Controls.Add(this.TBFM1);
            this.groupBox1.Controls.Add(this.TBFM2);
            this.groupBox1.Controls.Add(this.TBCE1);
            this.groupBox1.Location = new System.Drawing.Point(101, 133);
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
            // TBFM2
            // 
            this.TBFM2.Location = new System.Drawing.Point(170, 58);
            this.TBFM2.Name = "TBFM2";
            this.TBFM2.Size = new System.Drawing.Size(58, 20);
            this.TBFM2.TabIndex = 1;
            this.TBFM2.Tag = "1";
            this.TBFM2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBFM1_KeyPress);
            // 
            // TBFM1
            // 
            this.TBFM1.Location = new System.Drawing.Point(170, 29);
            this.TBFM1.Name = "TBFM1";
            this.TBFM1.Size = new System.Drawing.Size(58, 20);
            this.TBFM1.TabIndex = 0;
            this.TBFM1.Tag = "0";
            this.TBFM1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBFM1_KeyPress);
            // 
            // TBFM3
            // 
            this.TBFM3.Location = new System.Drawing.Point(170, 84);
            this.TBFM3.Name = "TBFM3";
            this.TBFM3.Size = new System.Drawing.Size(58, 20);
            this.TBFM3.TabIndex = 2;
            this.TBFM3.Tag = "2";
            this.TBFM3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBFM3_KeyPress);
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
            // TBCE3
            // 
            this.TBCE3.Location = new System.Drawing.Point(170, 84);
            this.TBCE3.Name = "TBCE3";
            this.TBCE3.Size = new System.Drawing.Size(58, 20);
            this.TBCE3.TabIndex = 18;
            this.TBCE3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBFM3_KeyPress);
            // 
            // TBCE2
            // 
            this.TBCE2.Location = new System.Drawing.Point(170, 58);
            this.TBCE2.Name = "TBCE2";
            this.TBCE2.Size = new System.Drawing.Size(58, 20);
            this.TBCE2.TabIndex = 17;
            this.TBCE2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBFM1_KeyPress);
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
            // TBCE1
            // 
            this.TBCE1.Location = new System.Drawing.Point(170, 29);
            this.TBCE1.Name = "TBCE1";
            this.TBCE1.Size = new System.Drawing.Size(58, 20);
            this.TBCE1.TabIndex = 16;
            this.TBCE1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBFM1_KeyPress);
            // 
            // TBGF1
            // 
            this.TBGF1.Location = new System.Drawing.Point(170, 29);
            this.TBGF1.Name = "TBGF1";
            this.TBGF1.Size = new System.Drawing.Size(58, 20);
            this.TBGF1.TabIndex = 7;
            this.TBGF1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBFM1_KeyPress);
            // 
            // TBGF3
            // 
            this.TBGF3.Location = new System.Drawing.Point(170, 84);
            this.TBGF3.Name = "TBGF3";
            this.TBGF3.Size = new System.Drawing.Size(58, 20);
            this.TBGF3.TabIndex = 9;
            this.TBGF3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBFM3_KeyPress);
            // 
            // TBCPP3
            // 
            this.TBCPP3.Location = new System.Drawing.Point(170, 84);
            this.TBCPP3.Name = "TBCPP3";
            this.TBCPP3.Size = new System.Drawing.Size(58, 20);
            this.TBCPP3.TabIndex = 15;
            this.TBCPP3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBFM3_KeyPress);
            // 
            // TBCPP2
            // 
            this.TBCPP2.Location = new System.Drawing.Point(170, 58);
            this.TBCPP2.Name = "TBCPP2";
            this.TBCPP2.Size = new System.Drawing.Size(58, 20);
            this.TBCPP2.TabIndex = 14;
            this.TBCPP2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBFM1_KeyPress);
            // 
            // TBGF2
            // 
            this.TBGF2.Location = new System.Drawing.Point(170, 58);
            this.TBGF2.Name = "TBGF2";
            this.TBGF2.Size = new System.Drawing.Size(58, 20);
            this.TBGF2.TabIndex = 8;
            this.TBGF2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBFM1_KeyPress);
            // 
            // TBCPP1
            // 
            this.TBCPP1.Location = new System.Drawing.Point(170, 29);
            this.TBCPP1.Name = "TBCPP1";
            this.TBCPP1.Size = new System.Drawing.Size(58, 20);
            this.TBCPP1.TabIndex = 13;
            this.TBCPP1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBFM1_KeyPress);
            // 
            // TBCKR3
            // 
            this.TBCKR3.Location = new System.Drawing.Point(170, 84);
            this.TBCKR3.Name = "TBCKR3";
            this.TBCKR3.Size = new System.Drawing.Size(58, 20);
            this.TBCKR3.TabIndex = 12;
            this.TBCKR3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBFM3_KeyPress);
            // 
            // TBCKR1
            // 
            this.TBCKR1.Location = new System.Drawing.Point(170, 29);
            this.TBCKR1.Name = "TBCKR1";
            this.TBCKR1.Size = new System.Drawing.Size(58, 20);
            this.TBCKR1.TabIndex = 10;
            this.TBCKR1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBFM1_KeyPress);
            // 
            // TBCKR2
            // 
            this.TBCKR2.Location = new System.Drawing.Point(170, 58);
            this.TBCKR2.Name = "TBCKR2";
            this.TBCKR2.Size = new System.Drawing.Size(58, 20);
            this.TBCKR2.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Название организации:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "ИНН:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Институт поддержки:";
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(199, 300);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(79, 23);
            this.Send.TabIndex = 19;
            this.Send.Text = "Отправить";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // MTB1
            // 
            this.MTB1.Location = new System.Drawing.Point(141, 268);
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
            this.label10.Location = new System.Drawing.Point(66, 271);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Дата отчета:";
            // 
            // MC1
            // 
            this.MC1.Location = new System.Drawing.Point(305, 271);
            this.MC1.Name = "MC1";
            this.MC1.TabIndex = 22;
            this.MC1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.MC1_DateSelected);
            // 
            // CB_INN
            // 
            this.CB_INN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_INN.FormattingEnabled = true;
            this.CB_INN.Location = new System.Drawing.Point(222, 14);
            this.CB_INN.Name = "CB_INN";
            this.CB_INN.Size = new System.Drawing.Size(238, 21);
            this.CB_INN.TabIndex = 23;
            this.CB_INN.SelectedIndexChanged += new System.EventHandler(this.CB_INN_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(204, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Общее кол-во созданых рабочих мест:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(222, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(59, 20);
            this.textBox1.TabIndex = 25;
            // 
            // TBcompName
            // 
            this.TBcompName.Location = new System.Drawing.Point(222, 41);
            this.TBcompName.Name = "TBcompName";
            this.TBcompName.ReadOnly = true;
            this.TBcompName.Size = new System.Drawing.Size(131, 20);
            this.TBcompName.TabIndex = 26;
            // 
            // SendRepForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(473, 331);
            this.Controls.Add(this.MC1);
            this.Controls.Add(this.TBcompName);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.CB_INN);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.MTB1);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CB1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "SendRepForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  Отчет";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.SendRepForm_Load);
            this.Click += new System.EventHandler(this.SendRepForm_Click);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox CB1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TBFM3;
        private System.Windows.Forms.TextBox TBFM2;
        private System.Windows.Forms.TextBox TBFM1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TBGF1;
        private System.Windows.Forms.TextBox TBGF2;
        private System.Windows.Forms.TextBox TBGF3;
        private System.Windows.Forms.TextBox TBCKR1;
        private System.Windows.Forms.TextBox TBCKR2;
        private System.Windows.Forms.TextBox TBCKR3;
        private System.Windows.Forms.TextBox TBCPP1;
        private System.Windows.Forms.TextBox TBCPP2;
        private System.Windows.Forms.TextBox TBCPP3;
        private System.Windows.Forms.TextBox TBCE1;
        private System.Windows.Forms.TextBox TBCE2;
        private System.Windows.Forms.TextBox TBCE3;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.MaskedTextBox MTB1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MonthCalendar MC1;
        private System.Windows.Forms.ComboBox CB_INN;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox TBcompName;
    }
}