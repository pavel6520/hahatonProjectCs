namespace hahatonProjectUser
{
    partial class SendReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendReportForm));
            this.CB_inst = new System.Windows.Forms.ComboBox();
            this.GroupBoxKPI = new System.Windows.Forms.GroupBox();
            this.Breset = new System.Windows.Forms.Button();
            this.LabelWorkplaces1 = new System.Windows.Forms.Label();
            this.LabelNumber1 = new System.Windows.Forms.Label();
            this.LabelWorkplaces = new System.Windows.Forms.Label();
            this.LabelNumber = new System.Windows.Forms.Label();
            this.LabelProceeds = new System.Windows.Forms.Label();
            this.LabelProceeds1 = new System.Windows.Forms.Label();
            this.TBparam3 = new System.Windows.Forms.TextBox();
            this.TBparam2 = new System.Windows.Forms.TextBox();
            this.TBparam1 = new System.Windows.Forms.TextBox();
            this.LabelCompName = new System.Windows.Forms.Label();
            this.LabelINN = new System.Windows.Forms.Label();
            this.LabelInst = new System.Windows.Forms.Label();
            this.Send = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.CB_compName = new System.Windows.Forms.ComboBox();
            this.TB_INN = new System.Windows.Forms.TextBox();
            this.TB_Year = new System.Windows.Forms.TextBox();
            this.CB_Quarter = new System.Windows.Forms.ComboBox();
            this.LabelQuarter = new System.Windows.Forms.Label();
            this.TimerUpdateDateTime = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.BresetAll = new System.Windows.Forms.Button();
            this.GroupBoxKPI.SuspendLayout();
            this.SuspendLayout();
            // 
            // CB_inst
            // 
            this.CB_inst.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_inst.FormattingEnabled = true;
            this.CB_inst.Items.AddRange(new object[] {
            "Фонд Микрофинансирования",
            "Гарантийный фонд",
            "Центр кластерного развития",
            "Центр поддержки предпринимательства",
            "Центр экспорта"});
            this.CB_inst.Location = new System.Drawing.Point(140, 60);
            this.CB_inst.Name = "CB_inst";
            this.CB_inst.Size = new System.Drawing.Size(238, 21);
            this.CB_inst.TabIndex = 2;
            this.CB_inst.SelectionChangeCommitted += new System.EventHandler(this.CB1_SelectionChangeCommitted);
            // 
            // GroupBoxKPI
            // 
            this.GroupBoxKPI.Controls.Add(this.Breset);
            this.GroupBoxKPI.Controls.Add(this.LabelWorkplaces1);
            this.GroupBoxKPI.Controls.Add(this.LabelNumber1);
            this.GroupBoxKPI.Controls.Add(this.LabelWorkplaces);
            this.GroupBoxKPI.Controls.Add(this.LabelNumber);
            this.GroupBoxKPI.Controls.Add(this.LabelProceeds);
            this.GroupBoxKPI.Controls.Add(this.LabelProceeds1);
            this.GroupBoxKPI.Controls.Add(this.TBparam3);
            this.GroupBoxKPI.Controls.Add(this.TBparam2);
            this.GroupBoxKPI.Controls.Add(this.TBparam1);
            this.GroupBoxKPI.Location = new System.Drawing.Point(10, 86);
            this.GroupBoxKPI.Name = "GroupBoxKPI";
            this.GroupBoxKPI.Size = new System.Drawing.Size(365, 103);
            this.GroupBoxKPI.TabIndex = 3;
            this.GroupBoxKPI.TabStop = false;
            this.GroupBoxKPI.Text = "Параметры KPI";
            // 
            // Breset
            // 
            this.Breset.Location = new System.Drawing.Point(284, 12);
            this.Breset.Name = "Breset";
            this.Breset.Size = new System.Drawing.Size(75, 23);
            this.Breset.TabIndex = 17;
            this.Breset.Text = "Сбросить";
            this.toolTip1.SetToolTip(this.Breset, "Сбросить параметры выбранного фонда");
            this.Breset.UseVisualStyleBackColor = true;
            this.Breset.Click += new System.EventHandler(this.BT_reset_Click);
            // 
            // LabelWorkplaces1
            // 
            this.LabelWorkplaces1.AutoSize = true;
            this.LabelWorkplaces1.Location = new System.Drawing.Point(221, 51);
            this.LabelWorkplaces1.Name = "LabelWorkplaces1";
            this.LabelWorkplaces1.Size = new System.Drawing.Size(23, 13);
            this.LabelWorkplaces1.TabIndex = 7;
            this.LabelWorkplaces1.Text = "шт.";
            // 
            // LabelNumber1
            // 
            this.LabelNumber1.AutoSize = true;
            this.LabelNumber1.Location = new System.Drawing.Point(221, 22);
            this.LabelNumber1.Name = "LabelNumber1";
            this.LabelNumber1.Size = new System.Drawing.Size(27, 13);
            this.LabelNumber1.TabIndex = 6;
            this.LabelNumber1.Text = "чел.";
            // 
            // LabelWorkplaces
            // 
            this.LabelWorkplaces.AutoSize = true;
            this.LabelWorkplaces.Location = new System.Drawing.Point(10, 51);
            this.LabelWorkplaces.Name = "LabelWorkplaces";
            this.LabelWorkplaces.Size = new System.Drawing.Size(145, 13);
            this.LabelWorkplaces.TabIndex = 4;
            this.LabelWorkplaces.Text = "Созданные рабочие места:";
            // 
            // LabelNumber
            // 
            this.LabelNumber.AutoSize = true;
            this.LabelNumber.Location = new System.Drawing.Point(11, 22);
            this.LabelNumber.Name = "LabelNumber";
            this.LabelNumber.Size = new System.Drawing.Size(144, 13);
            this.LabelNumber.TabIndex = 3;
            this.LabelNumber.Text = "Численность сотрудников:";
            // 
            // LabelProceeds
            // 
            this.LabelProceeds.AutoSize = true;
            this.LabelProceeds.Location = new System.Drawing.Point(102, 77);
            this.LabelProceeds.Name = "LabelProceeds";
            this.LabelProceeds.Size = new System.Drawing.Size(53, 13);
            this.LabelProceeds.TabIndex = 5;
            this.LabelProceeds.Text = "Выручка:";
            // 
            // LabelProceeds1
            // 
            this.LabelProceeds1.AutoSize = true;
            this.LabelProceeds1.Location = new System.Drawing.Point(221, 77);
            this.LabelProceeds1.Name = "LabelProceeds1";
            this.LabelProceeds1.Size = new System.Drawing.Size(30, 13);
            this.LabelProceeds1.TabIndex = 8;
            this.LabelProceeds1.Text = "млн.";
            // 
            // TBparam3
            // 
            this.TBparam3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBparam3.Location = new System.Drawing.Point(161, 74);
            this.TBparam3.Name = "TBparam3";
            this.TBparam3.Size = new System.Drawing.Size(58, 22);
            this.TBparam3.TabIndex = 16;
            this.TBparam3.Text = "0.0";
            this.TBparam3.Enter += new System.EventHandler(this.TBparam3_Enter);
            this.TBparam3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TBparam3_KeyDown);
            this.TBparam3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBparam3_KeyPress);
            this.TBparam3.Leave += new System.EventHandler(this.TBparam3_Leave);
            // 
            // TBparam2
            // 
            this.TBparam2.Location = new System.Drawing.Point(161, 48);
            this.TBparam2.Name = "TBparam2";
            this.TBparam2.Size = new System.Drawing.Size(58, 20);
            this.TBparam2.TabIndex = 12;
            this.TBparam2.Tag = "1";
            this.TBparam2.Text = "0";
            this.TBparam2.Enter += new System.EventHandler(this.TBparam2_Enter);
            this.TBparam2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TBparam2_KeyDown);
            this.TBparam2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBparam2_KeyPress);
            this.TBparam2.Leave += new System.EventHandler(this.TBparam2_Leave);
            // 
            // TBparam1
            // 
            this.TBparam1.Location = new System.Drawing.Point(161, 19);
            this.TBparam1.Name = "TBparam1";
            this.TBparam1.Size = new System.Drawing.Size(58, 20);
            this.TBparam1.TabIndex = 1;
            this.TBparam1.Text = "0";
            this.TBparam1.Enter += new System.EventHandler(this.TBparam1_Enter);
            this.TBparam1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TBparam1_KeyDown);
            this.TBparam1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBparam1_KeyPress);
            this.TBparam1.Leave += new System.EventHandler(this.TBparam1_Leave);
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
            this.Send.Location = new System.Drawing.Point(154, 262);
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
            this.label10.Location = new System.Drawing.Point(10, 238);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Год:";
            // 
            // CB_compName
            // 
            this.CB_compName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_compName.FormattingEnabled = true;
            this.CB_compName.Location = new System.Drawing.Point(140, 7);
            this.CB_compName.Name = "CB_compName";
            this.CB_compName.Size = new System.Drawing.Size(238, 21);
            this.CB_compName.TabIndex = 23;
            this.CB_compName.SelectedIndexChanged += new System.EventHandler(this.CB_INN_SelectedIndexChanged);
            // 
            // TB_INN
            // 
            this.TB_INN.Location = new System.Drawing.Point(140, 34);
            this.TB_INN.Name = "TB_INN";
            this.TB_INN.ReadOnly = true;
            this.TB_INN.Size = new System.Drawing.Size(131, 20);
            this.TB_INN.TabIndex = 26;
            // 
            // TB_Year
            // 
            this.TB_Year.Location = new System.Drawing.Point(44, 235);
            this.TB_Year.MaxLength = 4;
            this.TB_Year.Name = "TB_Year";
            this.TB_Year.Size = new System.Drawing.Size(32, 20);
            this.TB_Year.TabIndex = 27;
            this.TB_Year.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBYear_KeyPress);
            // 
            // CB_Quarter
            // 
            this.CB_Quarter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Quarter.FormattingEnabled = true;
            this.CB_Quarter.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.CB_Quarter.Location = new System.Drawing.Point(140, 235);
            this.CB_Quarter.Name = "CB_Quarter";
            this.CB_Quarter.Size = new System.Drawing.Size(53, 21);
            this.CB_Quarter.TabIndex = 28;
            this.CB_Quarter.SelectedIndexChanged += new System.EventHandler(this.CBQuarter_SelectedIndexChanged);
            // 
            // LabelQuarter
            // 
            this.LabelQuarter.AutoSize = true;
            this.LabelQuarter.Location = new System.Drawing.Point(82, 238);
            this.LabelQuarter.Name = "LabelQuarter";
            this.LabelQuarter.Size = new System.Drawing.Size(52, 13);
            this.LabelQuarter.TabIndex = 29;
            this.LabelQuarter.Text = "Квартал:";
            // 
            // TimerUpdateDateTime
            // 
            this.TimerUpdateDateTime.Enabled = true;
            this.TimerUpdateDateTime.Interval = 1000;
            this.TimerUpdateDateTime.Tick += new System.EventHandler(this.TimerUpdateDateTime_Tick);
            // 
            // BresetAll
            // 
            this.BresetAll.Location = new System.Drawing.Point(281, 195);
            this.BresetAll.Name = "BresetAll";
            this.BresetAll.Size = new System.Drawing.Size(94, 23);
            this.BresetAll.TabIndex = 30;
            this.BresetAll.Text = "Сбросить все";
            this.BresetAll.UseVisualStyleBackColor = true;
            this.BresetAll.Click += new System.EventHandler(this.BT_resetAll_Click);
            // 
            // SendReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(387, 297);
            this.Controls.Add(this.BresetAll);
            this.Controls.Add(this.LabelQuarter);
            this.Controls.Add(this.CB_Quarter);
            this.Controls.Add(this.TB_Year);
            this.Controls.Add(this.TB_INN);
            this.Controls.Add(this.CB_compName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.LabelInst);
            this.Controls.Add(this.LabelINN);
            this.Controls.Add(this.LabelCompName);
            this.Controls.Add(this.CB_inst);
            this.Controls.Add(this.GroupBoxKPI);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SendReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  Отчет";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SendRepForm_FormClosed);
            this.Load += new System.EventHandler(this.SendRepForm_Load);
            this.GroupBoxKPI.ResumeLayout(false);
            this.GroupBoxKPI.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox CB_inst;
        private System.Windows.Forms.GroupBox GroupBoxKPI;
        private System.Windows.Forms.TextBox TBparam2;
        private System.Windows.Forms.Label LabelProceeds;
        private System.Windows.Forms.Label LabelWorkplaces;
        private System.Windows.Forms.Label LabelNumber;
        private System.Windows.Forms.Label LabelCompName;
        private System.Windows.Forms.Label LabelINN;
        private System.Windows.Forms.Label LabelInst;
        private System.Windows.Forms.Label LabelProceeds1;
        private System.Windows.Forms.Label LabelWorkplaces1;
        private System.Windows.Forms.Label LabelNumber1;
        private System.Windows.Forms.TextBox TBparam3;
        private System.Windows.Forms.TextBox TBparam1;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox CB_compName;
        private System.Windows.Forms.TextBox TB_INN;
        private System.Windows.Forms.TextBox TB_Year;
        private System.Windows.Forms.ComboBox CB_Quarter;
        private System.Windows.Forms.Label LabelQuarter;
        private System.Windows.Forms.Timer TimerUpdateDateTime;
        private System.Windows.Forms.Button Breset;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button BresetAll;
    }
}