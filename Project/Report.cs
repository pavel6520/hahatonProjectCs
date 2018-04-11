using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Project
{
    public partial class SendRepForm : Form
    {
        private string [][]inn_comp;

        public SendRepForm()
        {
            InitializeComponent();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.ConnectForm.conn.Close();
            Environment.Exit(0);
        }

        private void ComboBox1_SelectionChangeCommitted(object sender, EventArgs e)
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
            MC1.Hide();

            MTB1.Text = MC1.TodayDate.ToShortDateString();


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

            //Program.ConnectForm.conn.Open();
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
                MessageBox.Show("Ошибка получения данных.\n" + ex, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
            Program.ConnectForm.conn.Close();
            if (CB_INN.Items.Count == 0)
            /*try
            {
                CM_INN.SelectedIndex = 0;
            }
            catch (ArgumentOutOfRangeException ex)*/
            {
                MessageBox.Show("На ваш аккаунт не зарегистрировано ни одной компании.\nОбратитесь к администратору.\n"/* + ex*/, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
            CB_INN.SelectedIndex = 0;
        }        

        private void MTB1_Click(object sender, EventArgs e)
        {
            MC1.Show();
        }

        private void SendRepForm_Click(object sender, EventArgs e)
        {
            MC1.Hide();
        }

        private void MC1_DateSelected(object sender, DateRangeEventArgs e)
        {
            MTB1.Text = MC1.SelectionStart.ToShortDateString();            
        }        

        private void Send_Click(object sender, EventArgs e)
        {

            DateTime date = DateTime.Now;
            date = MC1.SelectionStart;



            /*string query = "insert into reports value( ' " + TB2.Text + " ', ' " + date.ToString("yyyy.MM.dd") + " ', ' " + TB3.Text + " ', ' " +
                TB4.Text + " ', ' " + TB5.Text + " ', ' " + TB6.Text + " ', ' " + TB7.Text + " ', ' " + TB8.Text + " ', ' " + TB9.Text +
                " ', ' " + TB10.Text + " ', ' " + TB11.Text + " ', ' " + TB12.Text + " ', ' " + TB13.Text + " ', ' " + TB14.Text +
                 " ', ' " + TB15.Text + " ', ' " + TB16.Text + " ', ' " + TB14.Text + " ' )";

            MySqlCommand command = new MySqlCommand(query, Program.ConnectForm.conn);
            command.ExecuteScalar();*/
        }

        private void CB_INN_SelectedIndexChanged(object sender, EventArgs e)
        {
            TBcompName.Text = inn_comp[CB_INN.SelectedIndex][0];
        }

        private void TBcompName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
