using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace hahatonProjectUser
{
    public partial class SendReportForm : Form
    {
        private List<Structs.INN_Comp.Body_Element> inn_comp;
        private int SelectInst;        
        private Structs.Report valParams;

        private bool SaveParam()
        {
            try
            {
                if(Convert.ToInt32(TB_param1.Text) < 0)
                {
                    MessageBox.Show("Неверное значение параметра\n\"Численность сотрудников\"\nНе может быть меньше нуля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CB_inst.SelectedIndex = SelectInst;
                    return false;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Неверное значение параметра\n\"Численность сотрудников\"", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CB_inst.SelectedIndex = SelectInst;
                return false;
            }

            try
            {
                Convert.ToInt32(TB_param2.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Неверное значение параметра\n\"Созданные рабочие места\"", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CB_inst.SelectedIndex = SelectInst;
                return false;
            }

            try
            {
                Convert.ToDouble(TB_param3.Text.Replace('.', ','));
            }
            catch (FormatException)
            {
                MessageBox.Show("Неверное значение параметра\n\"Выручка\"", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CB_inst.SelectedIndex = SelectInst;
                return false;
            }

            valParams.param1[SelectInst] = Convert.ToInt32(TB_param1.Text);
            valParams.param2[SelectInst] = Convert.ToInt32(TB_param2.Text);
            valParams.param3[SelectInst] = Convert.ToDouble(TB_param3.Text.Replace('.',','));

            SelectInst = CB_inst.SelectedIndex;

            TB_param1.Text = valParams.param1[CB_inst.SelectedIndex].ToString();
            TB_param2.Text = valParams.param2[CB_inst.SelectedIndex].ToString().Replace(',', '.');

            if (valParams.param3[CB_inst.SelectedIndex] == 0.0)
            {
                TB_param3.Text = "0.0";
            }
            else
            {
                TB_param3.Text = valParams.param3[CB_inst.SelectedIndex].ToString();
            }

            return true;
        }
        
        public SendReportForm()
        {
            InitializeComponent();
        }

        private void SendRepForm_Load(object sender, EventArgs e)
        {
            CB_inst.SelectedIndex = 0;
            SelectInst = 0;

            Connection.Request(Structs.HOST, "1" + Structs.SEPARATOR_CHAR + JsonConvert.SerializeObject(new Structs.Authentication(Structs.login, Structs.password)));
            inn_comp = JsonConvert.DeserializeObject<Structs.INN_Comp>(Connection.Response()).body;

            for (int i = 0; i < inn_comp.Count; i++)
            {
                CB_compName.Items.Add(inn_comp[i].Comp_name);
            }

            if (CB_compName.Items.Count == 0)
            {
                Connection.Request(Structs.HOST, "2" + Structs.SEPARATOR_CHAR + JsonConvert.SerializeObject(new Structs.Authentication(Structs.login, Structs.password)));
                Functions.ShowError(Structs.Messages.СompaniesNotFound);

                Environment.Exit(0);
            }
            valParams.param1 = new int[] { 0, 0, 0, 0, 0 };
            valParams.param2 = new int[] { 0, 0, 0, 0, 0 };
            valParams.param3 = new double[] { 0.0, 0.0, 0.0, 0.0, 0.0 };

            CB_compName.SelectedIndex = 0;
            CB_Quarter.SelectedIndex = 0;
            int Year = DateTime.Now.Year;

            TB_Year.Text = DateTime.Now.Year.ToString();
            CB_Quarter.SelectedIndex = DateTime.Now.Month / 4;
        }

        private void CB1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if(SelectInst != CB_inst.SelectedIndex)
            {
                SaveParam();
            }
        }

        private void BT_Send_Click(object sender, EventArgs e)
        {
            if(SaveParam() == false)
            {
                return;
            }

            try
            {
                if (Convert.ToInt32(TB_Year.Text) < 1900 || Convert.ToInt32(TB_Year.Text) > 2999)
                {
                    Functions.ShowError(Structs.Messages.BadYearFormat);
                    return;
                }
            }
            catch (FormatException)
            {
                Functions.ShowError(Structs.Messages.BadYearFormat);
                return;
            }

            valParams.inn = TB_INN.Text;
            valParams.quarter = Convert.ToInt32(CB_Quarter.SelectedItem);
            valParams.year = Convert.ToInt32(TB_Year.Text);

            Connection.Request(Structs.HOST, "3" + Structs.SEPARATOR_CHAR + JsonConvert.SerializeObject(valParams));

            if (Connection.Response() == "1")
                Functions.ShowError(Structs.Messages.SuccessfulSend);
            else
                Functions.ShowError(Structs.Messages.ErrorSend);
        }

        private void CB_INN_SelectedIndexChanged(object sender, EventArgs e)
        {
            TB_INN.Text = inn_comp[CB_compName.SelectedIndex].INN;
        }

        private void BT_reset_Click(object sender, EventArgs e)
        {
            TB_param1.Text = "0";
            TB_param2.Text = "0";
            TB_param3.Text = "0.0";
            valParams.param1[CB_inst.SelectedIndex] = 0;
            valParams.param2[CB_inst.SelectedIndex] = 0;
            valParams.param3[CB_inst.SelectedIndex] = 0.0;
        }

        private void BT_resetAll_Click(object sender, EventArgs e)
        {
            TB_param1.Text = "0";
            TB_param2.Text = "0";
            TB_param3.Text = "0.0";
            valParams.param1 = new int[] { 0, 0, 0, 0, 0 };
            valParams.param2 = new int[] { 0, 0, 0, 0, 0 };
            valParams.param3 = new double[] { 0.0, 0.0, 0.0, 0.0, 0.0 };
        }

        private void TB_Year_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Validation.CharValidation(Validation.ValidationType.IntType, e.KeyChar);
        }

        private void TB_param1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Validation.CharValidation(Validation.ValidationType.IntType, e.KeyChar);
        }

        private void TB_param2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Validation.CharValidation(Validation.ValidationType.IntType, e.KeyChar);
        }

        private void TB_param3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Validation.CharValidation(Validation.ValidationType.DoubleType, e.KeyChar);
        }

        private void TB_param1_Enter(object sender, EventArgs e)
        {
            if (TB_param1.Text == "0")
            {
                TB_param1.Text = "";
            }
        }

        private void TB_param2_Enter(object sender, EventArgs e)
        {
            if (TB_param2.Text == "0")
            {
                TB_param2.Text = "";
            }
        }

        private void TB_param3_Enter(object sender, EventArgs e)
        {
            if (TB_param3.Text == "0.0")
            {
                TB_param3.Text = "";
            }
        }

        private void TB_param1_Leave(object sender, EventArgs e)
        {
            if(TB_param1.Text == "")
            {
                TB_param1.Text = "0";
            }
        }

        private void TB_param2_Leave(object sender, EventArgs e)
        {
            if (TB_param2.Text == "")
            {
                TB_param2.Text = "0";
            }
        }

        private void TB_param3_Leave(object sender, EventArgs e)
        {
            if (TB_param3.Text == "")
            {
                TB_param3.Text = "0.0";
            }
        }

        private void TB_param1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                e.Handled = true;
                TB_param2.Focus();
            }
            if (e.KeyCode == Keys.Up)
            {
                e.Handled = true;
                TB_param3.Focus();
            }
        }

        private void TB_param2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                e.Handled = true;
                TB_param3.Focus();
            }
            if (e.KeyCode == Keys.Up)
            {
                e.Handled = true;
                TB_param1.Focus();
            }
        }

        private void TB_param3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                e.Handled = true;
                TB_param1.Focus();
            }
            if (e.KeyCode == Keys.Up)
            {
                e.Handled = true;
                TB_param2.Focus();
            }
        }

        private void SendRepForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Connection.Request(Structs.HOST, "2" + Structs.SEPARATOR_CHAR + JsonConvert.SerializeObject(new Structs.Authentication(Structs.login, Structs.password)));

            Environment.Exit(0);
        }
    }
}
