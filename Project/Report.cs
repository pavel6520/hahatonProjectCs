using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using Newtonsoft.Json;



namespace hahatonProjectUser
{
    public partial class SendReportForm : Form
    {
        private List<Structs.INN_Comp.Body_Element> inn_comp;
        private DateTime dateNow;
        private int dateNowCountTime = 60;
        private int SelectInst;        
        private Structs.Report valParams;
        DateTime Quarter;

        private bool SaveParam()
        {
            try
            {
                if(Convert.ToInt32(TBparam1.Text) < 0)
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
                Convert.ToInt32(TBparam2.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Неверное значение параметра\n\"Созданные рабочие места\"", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CB_inst.SelectedIndex = SelectInst;
                return false;
            }

            try
            {
                Convert.ToDouble(TBparam3.Text.Replace('.', ','));
            }
            catch (FormatException)
            {
                MessageBox.Show("Неверное значение параметра\n\"Выручка\"", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CB_inst.SelectedIndex = SelectInst;
                return false;
            }

            valParams.param1[SelectInst] = Convert.ToInt32(TBparam1.Text);
            valParams.param2[SelectInst] = Convert.ToInt32(TBparam2.Text);
            valParams.param3[SelectInst] = Convert.ToDouble(TBparam3.Text.Replace('.',','));

            SelectInst = CB_inst.SelectedIndex;

            TBparam1.Text = valParams.param1[CB_inst.SelectedIndex].ToString();
            TBparam2.Text = valParams.param2[CB_inst.SelectedIndex].ToString().Replace(',', '.');

            if (valParams.param3[CB_inst.SelectedIndex] == 0.0)
            {
                TBparam3.Text = "0.0";
            }
            else
            {
                TBparam3.Text = valParams.param3[CB_inst.SelectedIndex].ToString();
            }

            return true;
        }
        
        public SendReportForm()
        {
            InitializeComponent();
        }

        private void TimerUpdateDateTime_Tick(object sender, EventArgs e)
        {
            /*if(dateNowCountTime >= 60)
            {
                try
                {
                    dateNow = Functions.GetNetworkTime();
                }
                catch (SocketException)
                {
                    dateNowCountTime = 0;
                    dateNow = dateNow.AddSeconds(1);

                    MessageBox.Show("Ошибка интернет-соединения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dateNowCountTime = 0;
            }
            else
            {
                dateNow = dateNow.AddSeconds(1);
            }
            dateNowCountTime++;*/
        }
        
        private void CB1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if(SelectInst != CB_inst.SelectedIndex)
            {
                SaveParam();
            }
        }

        private void SendRepForm_Load(object sender, EventArgs e)
        {
            //dateNow = Functions.GetNetworkTime();

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
                Functions.ShowError(Structs.Errors.СompaniesNotFound);

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

            /*Quarter = Convert.ToDateTime($"1001.{DateTime.Now.Month}.{DateTime.Now.Day}");

            if (Quarter >= Convert.ToDateTime("1001.1.1") && Quarter < Convert.ToDateTime("1001.03.25"))
            {
                TBYear.Text = $"{Year - 1}";
                CBQuarter.SelectedIndex = 3;
            }
            else if (Quarter >= Convert.ToDateTime("1001.03.25") && Quarter < Convert.ToDateTime("1001.06.25"))
            {
                TBYear.Text = $"{Year}";
                CBQuarter.SelectedIndex = 0;
            }
            else if (Quarter >= Convert.ToDateTime("1001.06.25") && Quarter < Convert.ToDateTime("1001.09.25"))
            {
                TBYear.Text = $"{Year}";
                CBQuarter.SelectedIndex = 1;
            }
            else if (Quarter >= Convert.ToDateTime("1001.09.25") && Quarter < Convert.ToDateTime("1001.12.25"))
            {
                TBYear.Text = $"{Year}";
                CBQuarter.SelectedIndex = 2;
            }
            else
            {
                TBYear.Text = $"{Year}";
                CBQuarter.SelectedIndex = 3;
            }*/
        }

        private void SendRepForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Connection.Request(Structs.HOST, "2" + Structs.SEPARATOR_CHAR + JsonConvert.SerializeObject(new Structs.Authentication(Structs.login, Structs.password)));

            Environment.Exit(0);
        }

        private void Send_Click(object sender, EventArgs e)
        {
            if(SaveParam() == false)
            {
                return;
            }

            try
            {
                try
                {
                    if (Convert.ToInt32(TB_Year.Text) < 1000)
                    {
                        MessageBox.Show("Неверный формат года", "Неверный формат", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show($"Неверный формат года", "Неверный формат", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string Quarter = "";

                switch (CB_Quarter.SelectedIndex)
                {
                    case 0:
                        Quarter = $"{TB_Year.Text}.03.25";
                        break;
                    case 1:
                        Quarter = $"{TB_Year.Text}.06.25";
                        break;
                    case 2:
                        Quarter = $"{TB_Year.Text}.09.25";
                        break;
                    case 3:
                        Quarter = $"{TB_Year.Text}.12.25";
                        break;
                }

                valParams.inn = TB_INN.Text;
                valParams.quarter = Convert.ToInt32(CB_Quarter.SelectedItem);
                valParams.year = Convert.ToInt32(TB_Year.Text);

                MessageBox.Show(valParams.inn + " " + valParams.quarter + " " + valParams.year);

                Connection.Request(Structs.HOST, "3" + Structs.SEPARATOR_CHAR + JsonConvert.SerializeObject(valParams));

                if (Connection.Response() == "1")
                    MessageBox.Show("Успешно отправлено.", "Отправлено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Ошибка отправки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                /*dateNow = GetNetworkTime();
                string query = $"insert into project.`{TBcompName.Text}` value('{Quarter}', '{dateNow.ToString("yyyy.MM.dd HH:mm:ss")}', '" +
                    $"{ValParams.param1[0]}', '{ValParams.param2[0]}', '" +
                    $"{ValParams.param3[0].ToString("G", CultureInfo.InvariantCulture)}', '" +
                    $"{ValParams.param1[1]}', '{ValParams.param2[1]}', '" +
                    $"{ValParams.param3[1].ToString("G", CultureInfo.InvariantCulture)}', '" +
                    $"{ValParams.param1[2]}', '{ValParams.param2[2]}', '" +
                    $"{ValParams.param3[2].ToString("G", CultureInfo.InvariantCulture)}', '" +
                    $"{ValParams.param1[3]}', '{ValParams.param2[3]}', '" +
                    $"{ValParams.param3[3].ToString("G", CultureInfo.InvariantCulture)}', '" +
                    $"{ValParams.param1[4]}', '{ValParams.param2[4]}', '" +
                    $"{ValParams.param3[4].ToString("G", CultureInfo.InvariantCulture)}')";*/
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка отправки\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void CB_INN_SelectedIndexChanged(object sender, EventArgs e)
        {
            TB_INN.Text = inn_comp[CB_compName.SelectedIndex].INN;
        }
        
        private void CBQuarter_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Breset_Click(object sender, EventArgs e)
        {
            TBparam1.Text = "0";
            TBparam2.Text = "0";
            TBparam3.Text = "0.0";
            valParams.param1[CB_inst.SelectedIndex] = 0;
            valParams.param2[CB_inst.SelectedIndex] = 0;
            valParams.param3[CB_inst.SelectedIndex] = 0.0;
        }

        private void BresetAll_Click(object sender, EventArgs e)
        {
            TBparam1.Text = "0";
            TBparam2.Text = "0";
            TBparam3.Text = "0.0";
            valParams.param1 = new int[] { 0, 0, 0, 0, 0 };
            valParams.param2 = new int[] { 0, 0, 0, 0, 0 };
            valParams.param3 = new double[] { 0.0, 0.0, 0.0, 0.0, 0.0 };
        }

        private void TBYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Validation.CharValidation(Validation.ValidationType.IntType, e.KeyChar);
        }

        private void TBparam1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Validation.CharValidation(Validation.ValidationType.IntType, e.KeyChar);
        }

        private void TBparam2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Validation.CharValidation(Validation.ValidationType.IntType, e.KeyChar);
        }

        private void TBparam3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Validation.CharValidation(Validation.ValidationType.DoubleType, e.KeyChar);
        }

        private void TBparam1_Enter(object sender, EventArgs e)
        {
            if (TBparam1.Text == "0")
            {
                TBparam1.Text = "";
            }
        }

        private void TBparam2_Enter(object sender, EventArgs e)
        {
            if (TBparam2.Text == "0")
            {
                TBparam2.Text = "";
            }
        }

        private void TBparam3_Enter(object sender, EventArgs e)
        {
            if (TBparam3.Text == "0.0")
            {
                TBparam3.Text = "";
            }
        }

        private void TBparam1_Leave(object sender, EventArgs e)
        {
            if(TBparam1.Text == "")
            {
                TBparam1.Text = "0";
            }
        }

        private void TBparam2_Leave(object sender, EventArgs e)
        {
            if (TBparam2.Text == "")
            {
                TBparam2.Text = "0";
            }
        }

        private void TBparam3_Leave(object sender, EventArgs e)
        {
            if (TBparam3.Text == "")
            {
                TBparam3.Text = "0.0";
            }
        }

        private void TBparam1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                e.Handled = true;
                TBparam2.Focus();
            }
            if (e.KeyCode == Keys.Up)
            {
                e.Handled = true;
                TBparam3.Focus();
            }
        }

        private void TBparam2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                e.Handled = true;
                TBparam3.Focus();
            }
            if (e.KeyCode == Keys.Up)
            {
                e.Handled = true;
                TBparam1.Focus();
            }
        }

        private void TBparam3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                e.Handled = true;
                TBparam1.Focus();
            }
            if (e.KeyCode == Keys.Up)
            {
                e.Handled = true;
                TBparam2.Focus();
            }
        }
    }
}
