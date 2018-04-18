using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Project
{
    public partial class SendRepForm : Form
    {
        private string [][]inn_comp;
        private string MMDD;
        private DateTime dateNow;
        private int dateNowCountTime = 60;
        
        public SendRepForm()
        {
            InitializeComponent();
        }

        private bool Is_dig(char x)
        {
            if (Char.IsDigit(x))
                return true;
            else return false;
        }

        private void TimerUpdateDateTime_Tick(object sender, EventArgs e)
        {
            if(dateNowCountTime >= 60)
            {
                dateNow = GetNetworkTime();
                dateNowCountTime = 0;
            }
            else
            {
                dateNow = dateNow.AddSeconds(1);
            }
            dateNowCountTime++;
        }

        public static DateTime GetNetworkTime()
        {
            const string ntpServer = "time.windows.com";
            var ntpData = new byte[48];
            ntpData[0] = 0x1B;
            var addresses = Dns.GetHostEntry(ntpServer).AddressList;
            var ipEndPoint = new IPEndPoint(addresses[0], 123);
            using (var socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp))
            {
                socket.Connect(ipEndPoint);
                socket.Send(ntpData);
                socket.Receive(ntpData);
                socket.Close();
            }
            var intPart = (ulong)ntpData[40] << 24 | (ulong)ntpData[41] << 16 | (ulong)ntpData[42] << 8 | ntpData[43];
            var fractPart = (ulong)ntpData[44] << 24 | (ulong)ntpData[45] << 16 | (ulong)ntpData[46] << 8 | ntpData[47];
            var milliseconds = (intPart * 1000) + ((fractPart * 1000) / 0x100000000L);
            var networkDateTime = (new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc)).AddMilliseconds((long)milliseconds);
            return networkDateTime.ToLocalTime();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            //TimerUpdateDateTime.Stop();
            Environment.Exit(0);
        }

        private void CB1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            switch (CB1.SelectedIndex)
            {
                case 0:
                    TBFM1.Show();
                    TBFM2.Show();
                    TBFM3.Show();
                    TBGF1.Hide();
                    TBGF2.Hide();
                    TBGF3.Hide();
                    TBCKR1.Hide();
                    TBCKR2.Hide();
                    TBCKR3.Hide();
                    TBCPP1.Hide();
                    TBCPP2.Hide();
                    TBCPP3.Hide();
                    TBCE1.Hide();
                    TBCE2.Hide();
                    TBCE3.Hide();
                    break;
                case 1:
                    TBFM1.Hide();
                    TBFM2.Hide();
                    TBFM3.Hide();
                    TBGF1.Show();
                    TBGF2.Show();
                    TBGF3.Show();
                    TBCKR1.Hide();
                    TBCKR2.Hide();
                    TBCKR3.Hide();
                    TBCPP1.Hide();
                    TBCPP2.Hide();
                    TBCPP3.Hide();
                    TBCE1.Hide();
                    TBCE2.Hide();
                    TBCE3.Hide();
                    break;
                case 2:
                    TBFM1.Hide();
                    TBFM2.Hide();
                    TBFM3.Hide();
                    TBGF1.Hide();
                    TBGF2.Hide();
                    TBGF3.Hide();
                    TBCKR1.Show();
                    TBCKR2.Show();
                    TBCKR3.Show();
                    TBCPP1.Hide();
                    TBCPP2.Hide();
                    TBCPP3.Hide();
                    TBCE1.Hide();
                    TBCE2.Hide();
                    TBCE3.Hide();
                    break;
                case 3:
                    TBFM1.Hide();
                    TBFM2.Hide();
                    TBFM3.Hide();
                    TBGF1.Hide();
                    TBGF2.Hide();
                    TBGF3.Hide();
                    TBCKR1.Hide();
                    TBCKR2.Hide();
                    TBCKR3.Hide();
                    TBCPP1.Show();
                    TBCPP2.Show();
                    TBCPP3.Show();
                    TBCE1.Hide();
                    TBCE2.Hide();
                    TBCE3.Hide();
                    break;
                case 4:
                    TBFM1.Hide();
                    TBFM2.Hide();
                    TBFM3.Hide();
                    TBGF1.Hide();
                    TBGF2.Hide();
                    TBGF3.Hide();
                    TBCKR1.Hide();
                    TBCKR2.Hide();
                    TBCKR3.Hide();
                    TBCPP1.Hide();
                    TBCPP2.Hide();
                    TBCPP3.Hide();
                    TBCE1.Show();
                    TBCE2.Show();
                    TBCE3.Show();
                    break;
            }
        }

        private void SendRepForm_Load(object sender, EventArgs e)
        {
            dateNow = GetNetworkTime();
            CB1.SelectedIndex = 0;
            TBFM1.Show(); TBFM1.Text = "0";
            TBFM2.Show(); TBFM2.Text = "0";
            TBFM3.Show(); TBFM3.Text = "0.0";
            TBGF1.Hide(); TBGF1.Text = "0";
            TBGF2.Hide(); TBGF2.Text = "0";
            TBGF3.Hide(); TBGF3.Text = "0.0";
            TBCKR1.Hide(); TBCKR1.Text = "0";
            TBCKR2.Hide(); TBCKR2.Text = "0";
            TBCKR3.Hide(); TBCKR3.Text = "0.0";
            TBCPP1.Hide(); TBCPP1.Text = "0";
            TBCPP2.Hide(); TBCPP2.Text = "0";
            TBCPP3.Hide(); TBCPP3.Text = "0.0";
            TBCE1.Hide(); TBCE1.Text = "0";
            TBCE2.Hide(); TBCE2.Text = "0";
            TBCE3.Hide(); TBCE3.Text = "0.0";
            MySqlCommand com;
            MySqlDataReader readed;
            int count = 0;
            try
            {
                com = new MySqlCommand("select INN, comp_name from project.login_inn where login = '" + Program.ConnectForm.login + "'", Program.ConnectForm.conn);
                readed = com.ExecuteReader();
                count = 1;
                inn_comp = new string[1][];
                while (readed.Read())
                {
                    Array.Resize(ref inn_comp, count);
                    inn_comp[count - 1] = new string[2];
                    inn_comp[count - 1][0] = readed[0].ToString();
                    inn_comp[count - 1][1] = readed[1].ToString();
                    CB_INN.Items.Insert(count - 1, inn_comp[count - 1][1]);
                    count++;
                }
            }
            catch (MySqlException ex)
            {
                Program.ConnectForm.conn.Close();
                MessageBox.Show("Ошибка получения данных.\n" + ex, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
            Program.ConnectForm.conn.Close();
            if (CB_INN.Items.Count == 0)
            {
                MessageBox.Show("На ваш аккаунт не зарегистрировано ни одной компании.\nОбратитесь к администратору.\n"/* + ex*/, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
            CB_INN.SelectedIndex = 0;
            CBQuarter.SelectedIndex = 0;
        }

        private void Send_Click(object sender, EventArgs e)
        {
            try
            {
                Program.ConnectForm.conn.Open();
                DateTime dateReport = Convert.ToDateTime(TBYear.Text + "." + MMDD);
                dateNow = GetNetworkTime();

                //Обработка пустых полей, формата чисел

                string query = "insert into project.`" + TBcompName.Text + "` value('" + 
                    dateReport.ToString("yyyy.MM.dd") + "', '" + dateNow.ToString("yyyy.MM.dd HH:mm:ss") +
                    "', '" + TBFM1.Text + "', '" + TBFM2.Text + "', '" + TBFM3.Text +
                    "', '" + TBGF1.Text + "', '" + TBGF2.Text + "', '" + TBGF3.Text +
                    "', '" + TBCKR1.Text + "', '" + TBCKR2.Text + "', '" + TBCKR3.Text +
                    "', '" + TBCPP1.Text + "', '" + TBCPP2.Text + "', '" + TBCPP3.Text +
                    "', '" + TBCE1.Text + "', '" + TBCE2.Text + "', '" + TBCE3.Text + "')";

                MySqlCommand command = new MySqlCommand(query, Program.ConnectForm.conn);
                command.ExecuteNonQuery();
                Program.ConnectForm.conn.Close();
            }
            catch (MySqlException ex)
            {
                Program.ConnectForm.conn.Close();
                MessageBox.Show("Error\n" + ex);
            }
            Thread.Sleep(1000);
            MessageBox.Show("Успешно отправлено.", "Отправлено", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CB_INN_SelectedIndexChanged(object sender, EventArgs e)
        {
            TBcompName.Text = inn_comp[CB_INN.SelectedIndex][0];
        }


        private void TBFM3_KeyPress(object sender, KeyPressEventArgs e)
        {   
            if (Program.In_Float(e.KeyChar))
                e.Handled = true;
        }

        private void TBFM1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Program.In_Int(e.KeyChar))
                e.Handled = true;
        }

        private void CBQuarter_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (CBQuarter.SelectedIndex)
            {
                case 0:
                    {
                        MMDD = "03.25";
                        break;
                    }
                case 1:
                    {
                        MMDD = "06.25";
                        break;
                    }
                case 2:
                    {
                        MMDD = "09.25";
                        break;
                    }
                case 3:
                    {
                        MMDD = "12.25";
                        break;
                    }
            }
        }
    }
}
