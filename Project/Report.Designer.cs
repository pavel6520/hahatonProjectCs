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
            this.components = new System.ComponentModel.Container();
            this.CB1 = new System.Windows.Forms.ComboBox();
            this.GroupBoxKPI = new System.Windows.Forms.GroupBox();
            this.LabelWorkplaces1 = new System.Windows.Forms.Label();
            this.LabelNumber1 = new System.Windows.Forms.Label();
            this.LabelWorkplaces = new System.Windows.Forms.Label();
            this.LabelNumber = new System.Windows.Forms.Label();
            this.TBCPP3 = new System.Windows.Forms.TextBox();
            this.TBCPP1 = new System.Windows.Forms.TextBox();
            this.TBCE3 = new System.Windows.Forms.TextBox();
            this.TBCPP2 = new System.Windows.Forms.TextBox();
            this.TBGF3 = new System.Windows.Forms.TextBox();
            this.TBGF2 = new System.Windows.Forms.TextBox();
            this.TBFM3 = new System.Windows.Forms.TextBox();
            this.TBGF1 = new System.Windows.Forms.TextBox();
            this.LabelProceeds = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TBCKR3 = new System.Windows.Forms.TextBox();
            this.TBCKR1 = new System.Windows.Forms.TextBox();
            this.TBCKR2 = new System.Windows.Forms.TextBox();
            this.TBCE2 = new System.Windows.Forms.TextBox();
            this.TBFM1 = new System.Windows.Forms.TextBox();
            this.TBFM2 = new System.Windows.Forms.TextBox();
            this.TBCE1 = new System.Windows.Forms.TextBox();
            this.LabelCompName = new System.Windows.Forms.Label();
            this.LabelINN = new System.Windows.Forms.Label();
            this.LabelInst = new System.Windows.Forms.Label();
            this.Send = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.CB_INN = new System.Windows.Forms.ComboBox();
            this.TBcompName = new System.Windows.Forms.TextBox();
            this.TBYear = new System.Windows.Forms.TextBox();
            this.CBQuarter = new System.Windows.Forms.ComboBox();
            this.LabelQuarter = new System.Windows.Forms.Label();
            this.LabelDateTime = new System.Windows.Forms.Label();
            this.TimerUpdateDateTime = new System.Windows.Forms.Timer(this.components);
            this.GroupBoxKPI.SuspendLayout();
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
            this.CB1.Location = new System.Drawing.Point(140, 60);
            this.CB1.Name = "CB1";
            this.CB1.Size = new System.Drawing.Size(238, 21);
            this.CB1.TabIndex = 2;
            this.CB1.SelectionChangeCommitted += new System.EventHandler(this.CB1_SelectionChangeCommitted);
            // 
            // GroupBoxKPI
            // 
            this.GroupBoxKPI.Controls.Add(this.LabelWorkplaces1);
            this.GroupBoxKPI.Controls.Add(this.LabelNumber1);
            this.GroupBoxKPI.Controls.Add(this.LabelWorkplaces);
            this.GroupBoxKPI.Controls.Add(this.LabelNumber);
            this.GroupBoxKPI.Controls.Add(this.TBCPP3);
            this.GroupBoxKPI.Controls.Add(this.TBCPP1);
            this.GroupBoxKPI.Controls.Add(this.TBCE3);
            this.GroupBoxKPI.Controls.Add(this.TBCPP2);
            this.GroupBoxKPI.Controls.Add(this.TBGF3);
            this.GroupBoxKPI.Controls.Add(this.TBGF2);
            this.GroupBoxKPI.Controls.Add(this.TBFM3);
            this.GroupBoxKPI.Controls.Add(this.TBGF1);
            this.GroupBoxKPI.Controls.Add(this.LabelProceeds);
            this.GroupBoxKPI.Controls.Add(this.label9);
            this.GroupBoxKPI.Controls.Add(this.TBCKR3);
            this.GroupBoxKPI.Controls.Add(this.TBCKR1);
            this.GroupBoxKPI.Controls.Add(this.TBCKR2);
            this.GroupBoxKPI.Controls.Add(this.TBCE2);
            this.GroupBoxKPI.Controls.Add(this.TBFM1);
            this.GroupBoxKPI.Controls.Add(this.TBFM2);
            this.GroupBoxKPI.Controls.Add(this.TBCE1);
            this.GroupBoxKPI.Location = new System.Drawing.Point(10, 86);
            this.GroupBoxKPI.Name = "GroupBoxKPI";
            this.GroupBoxKPI.Size = new System.Drawing.Size(276, 119);
            this.GroupBoxKPI.TabIndex = 3;
            this.GroupBoxKPI.TabStop = false;
            this.GroupBoxKPI.Text = "Параметры KPI";
            // 
            // LabelWorkplaces1
            // 
            this.LabelWorkplaces1.AutoSize = true;
            this.LabelWorkplaces1.Location = new System.Drawing.Point(230, 61);
            this.LabelWorkplaces1.Name = "LabelWorkplaces1";
            this.LabelWorkplaces1.Size = new System.Drawing.Size(23, 13);
            this.LabelWorkplaces1.TabIndex = 7;
            this.LabelWorkplaces1.Text = "шт.";
            // 
            // LabelNumber1
            // 
            this.LabelNumber1.AutoSize = true;
            this.LabelNumber1.Location = new System.Drawing.Point(230, 32);
            this.LabelNumber1.Name = "LabelNumber1";
            this.LabelNumber1.Size = new System.Drawing.Size(27, 13);
            this.LabelNumber1.TabIndex = 6;
            this.LabelNumber1.Text = "чел.";
            // 
            // LabelWorkplaces
            // 
            this.LabelWorkplaces.AutoSize = true;
            this.LabelWorkplaces.Location = new System.Drawing.Point(19, 61);
            this.LabelWorkplaces.Name = "LabelWorkplaces";
            this.LabelWorkplaces.Size = new System.Drawing.Size(145, 13);
            this.LabelWorkplaces.TabIndex = 4;
            this.LabelWorkplaces.Text = "Созданные рабочие места:";
            // 
            // LabelNumber
            // 
            this.LabelNumber.AutoSize = true;
            this.LabelNumber.Location = new System.Drawing.Point(20, 32);
            this.LabelNumber.Name = "LabelNumber";
            this.LabelNumber.Size = new System.Drawing.Size(144, 13);
            this.LabelNumber.TabIndex = 3;
            this.LabelNumber.Text = "Численность сотрудников:";
            // 
            // TBCPP3
            // 
            this.TBCPP3.Location = new System.Drawing.Point(170, 84);
            this.TBCPP3.Name = "TBCPP3";
            this.TBCPP3.Size = new System.Drawing.Size(58, 20);
            this.TBCPP3.TabIndex = 15;
            this.TBCPP3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBFM3_KeyPress);
            // 
            // TBCPP1
            // 
            this.TBCPP1.Location = new System.Drawing.Point(170, 29);
            this.TBCPP1.Name = "TBCPP1";
            this.TBCPP1.Size = new System.Drawing.Size(58, 20);
            this.TBCPP1.TabIndex = 13;
            this.TBCPP1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBFM1_KeyPress);
            // 
            // TBCE3
            // 
            this.TBCE3.Location = new System.Drawing.Point(170, 84);
            this.TBCE3.Name = "TBCE3";
            this.TBCE3.Size = new System.Drawing.Size(58, 20);
            this.TBCE3.TabIndex = 18;
            this.TBCE3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBFM3_KeyPress);
            // 
            // TBCPP2
            // 
            this.TBCPP2.Location = new System.Drawing.Point(170, 58);
            this.TBCPP2.Name = "TBCPP2";
            this.TBCPP2.Size = new System.Drawing.Size(58, 20);
            this.TBCPP2.TabIndex = 14;
            this.TBCPP2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBFM1_KeyPress);
            // 
            // TBGF3
            // 
            this.TBGF3.Location = new System.Drawing.Point(170, 84);
            this.TBGF3.Name = "TBGF3";
            this.TBGF3.Size = new System.Drawing.Size(58, 20);
            this.TBGF3.TabIndex = 9;
            this.TBGF3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBFM3_KeyPress);
            // 
            // TBGF2
            // 
            this.TBGF2.Location = new System.Drawing.Point(170, 58);
            this.TBGF2.Name = "TBGF2";
            this.TBGF2.Size = new System.Drawing.Size(58, 20);
            this.TBGF2.TabIndex = 8;
            this.TBGF2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBFM1_KeyPress);
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
            // TBGF1
            // 
            this.TBGF1.Location = new System.Drawing.Point(170, 29);
            this.TBGF1.Name = "TBGF1";
            this.TBGF1.Size = new System.Drawing.Size(58, 20);
            this.TBGF1.TabIndex = 7;
            this.TBGF1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBFM1_KeyPress);
            // 
            // LabelProceeds
            // 
            this.LabelProceeds.AutoSize = true;
            this.LabelProceeds.Location = new System.Drawing.Point(111, 87);
            this.LabelProceeds.Name = "LabelProceeds";
            this.LabelProceeds.Size = new System.Drawing.Size(53, 13);
            this.LabelProceeds.TabIndex = 5;
            this.LabelProceeds.Text = "Выручка:";
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
            // TBCE2
            // 
            this.TBCE2.Location = new System.Drawing.Point(170, 58);
            this.TBCE2.Name = "TBCE2";
            this.TBCE2.Size = new System.Drawing.Size(58, 20);
            this.TBCE2.TabIndex = 17;
            this.TBCE2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBFM1_KeyPress);
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
            // TBFM2
            // 
            this.TBFM2.Location = new System.Drawing.Point(170, 58);
            this.TBFM2.Name = "TBFM2";
            this.TBFM2.Size = new System.Drawing.Size(58, 20);
            this.TBFM2.TabIndex = 1;
            this.TBFM2.Tag = "1";
            this.TBFM2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBFM1_KeyPress);
            // 
            // TBCE1
            // 
            this.TBCE1.Location = new System.Drawing.Point(170, 29);
            this.TBCE1.Name = "TBCE1";
            this.TBCE1.Size = new System.Drawing.Size(58, 20);
            this.TBCE1.TabIndex = 16;
            this.TBCE1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBFM1_KeyPress);
            // 
            // LabelCompName
            // 
            this.LabelCompName.AutoSize = true;
            this.LabelCompName.Location = new System.Drawing.Point(6, 10);
            this.LabelCompName.Name = "LabelCompName";
            this.LabelCompName.Size = new System.Drawing.Size(128, 13);
            this.LabelCompName.TabIndex = 4;
            this.LabelCompName.Text = "Название организации:";
            // 
            // LabelINN
            // 
            this.LabelINN.AutoSize = true;
            this.LabelINN.Location = new System.Drawing.Point(100, 37);
            this.LabelINN.Name = "LabelINN";
            this.LabelINN.Size = new System.Drawing.Size(34, 13);
            this.LabelINN.TabIndex = 5;
            this.LabelINN.Text = "ИНН:";
            // 
            // LabelInst
            // 
            this.LabelInst.AutoSize = true;
            this.LabelInst.Location = new System.Drawing.Point(19, 63);
            this.LabelInst.Name = "LabelInst";
            this.LabelInst.Size = new System.Drawing.Size(115, 13);
            this.LabelInst.TabIndex = 6;
            this.LabelInst.Text = "Институт поддержки:";
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(182, 237);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(79, 23);
            this.Send.TabIndex = 19;
            this.Send.Text = "Отправить";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 214);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Год:";
            // 
            // CB_INN
            // 
            this.CB_INN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_INN.FormattingEnabled = true;
            this.CB_INN.Location = new System.Drawing.Point(140, 7);
            this.CB_INN.Name = "CB_INN";
            this.CB_INN.Size = new System.Drawing.Size(238, 21);
            this.CB_INN.TabIndex = 23;
            this.CB_INN.SelectedIndexChanged += new System.EventHandler(this.CB_INN_SelectedIndexChanged);
            // 
            // TBcompName
            // 
            this.TBcompName.Location = new System.Drawing.Point(140, 34);
            this.TBcompName.Name = "TBcompName";
            this.TBcompName.ReadOnly = true;
            this.TBcompName.Size = new System.Drawing.Size(131, 20);
            this.TBcompName.TabIndex = 26;
            // 
            // TBYear
            // 
            this.TBYear.Location = new System.Drawing.Point(44, 211);
            this.TBYear.MaxLength = 4;
            this.TBYear.Name = "TBYear";
            this.TBYear.Size = new System.Drawing.Size(32, 20);
            this.TBYear.TabIndex = 27;
            // 
            // CBQuarter
            // 
            this.CBQuarter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBQuarter.FormattingEnabled = true;
            this.CBQuarter.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.CBQuarter.Location = new System.Drawing.Point(140, 210);
            this.CBQuarter.Name = "CBQuarter";
            this.CBQuarter.Size = new System.Drawing.Size(121, 21);
            this.CBQuarter.TabIndex = 28;
            this.CBQuarter.SelectedIndexChanged += new System.EventHandler(this.CBQuarter_SelectedIndexChanged);
            // 
            // LabelQuarter
            // 
            this.LabelQuarter.AutoSize = true;
            this.LabelQuarter.Location = new System.Drawing.Point(82, 214);
            this.LabelQuarter.Name = "LabelQuarter";
            this.LabelQuarter.Size = new System.Drawing.Size(52, 13);
            this.LabelQuarter.TabIndex = 29;
            this.LabelQuarter.Text = "Квартал:";
            // 
            // LabelDateTime
            // 
            this.LabelDateTime.AutoSize = true;
            this.LabelDateTime.Location = new System.Drawing.Point(10, 247);
            this.LabelDateTime.Name = "LabelDateTime";
            this.LabelDateTime.Size = new System.Drawing.Size(0, 13);
            this.LabelDateTime.TabIndex = 30;
            // 
            // TimerUpdateDateTime
            // 
            this.TimerUpdateDateTime.Enabled = true;
            this.TimerUpdateDateTime.Interval = 1000;
            this.TimerUpdateDateTime.Tick += new System.EventHandler(this.TimerUpdateDateTime_Tick);
            // 
            // SendRepForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(387, 288);
            this.Controls.Add(this.LabelDateTime);
            this.Controls.Add(this.LabelQuarter);
            this.Controls.Add(this.CBQuarter);
            this.Controls.Add(this.TBYear);
            this.Controls.Add(this.TBcompName);
            this.Controls.Add(this.CB_INN);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.LabelInst);
            this.Controls.Add(this.LabelINN);
            this.Controls.Add(this.LabelCompName);
            this.Controls.Add(this.CB1);
            this.Controls.Add(this.GroupBoxKPI);
            this.MaximizeBox = false;
            this.Name = "SendRepForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  Отчет";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.SendRepForm_Load);
            this.GroupBoxKPI.ResumeLayout(false);
            this.GroupBoxKPI.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox CB1;
        private System.Windows.Forms.GroupBox GroupBoxKPI;
        private System.Windows.Forms.TextBox TBFM3;
        private System.Windows.Forms.TextBox TBFM2;
        private System.Windows.Forms.TextBox TBFM1;
        private System.Windows.Forms.Label LabelProceeds;
        private System.Windows.Forms.Label LabelWorkplaces;
        private System.Windows.Forms.Label LabelNumber;
        private System.Windows.Forms.Label LabelCompName;
        private System.Windows.Forms.Label LabelINN;
        private System.Windows.Forms.Label LabelInst;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LabelWorkplaces1;
        private System.Windows.Forms.Label LabelNumber1;
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
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox CB_INN;
        private System.Windows.Forms.TextBox TBcompName;
        private System.Windows.Forms.TextBox TBYear;
        private System.Windows.Forms.ComboBox CBQuarter;
        private System.Windows.Forms.Label LabelQuarter;
        private System.Windows.Forms.Label LabelDateTime;
        private System.Windows.Forms.Timer TimerUpdateDateTime;
    }
}