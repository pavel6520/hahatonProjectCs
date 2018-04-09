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
                    TB3.Show();
                    TB4.Show();
                    TB5.Show();
                    TB6.Hide();
                    TB7.Hide();
                    TB8.Hide();
                    TB9.Hide();
                    TB10.Hide();
                    TB11.Hide();
                    TB12.Hide();
                    TB13.Hide();
                    TB14.Hide();
                    TB15.Hide();
                    TB16.Hide();
                    TB17.Hide();
                    break;
                case 1:
                    TB3.Hide();
                    TB4.Hide();
                    TB5.Hide();
                    TB6.Show();
                    TB7.Show();
                    TB8.Show();
                    TB9.Hide();
                    TB10.Hide();
                    TB11.Hide();
                    TB12.Hide();
                    TB13.Hide();
                    TB14.Hide();
                    TB15.Hide();
                    TB16.Hide();
                    TB17.Hide();
                    break;
                case 2:
                    TB3.Hide();
                    TB4.Hide();
                    TB5.Hide();
                    TB6.Hide();
                    TB7.Hide();
                    TB8.Hide();
                    TB9.Show();
                    TB10.Show();
                    TB11.Show();
                    TB12.Hide();
                    TB13.Hide();
                    TB14.Hide();
                    TB15.Hide();
                    TB16.Hide();
                    TB17.Hide();
                    break;
                case 3:
                    TB3.Hide();
                    TB4.Hide();
                    TB5.Hide();
                    TB6.Hide();
                    TB7.Hide();
                    TB8.Hide();
                    TB9.Hide();
                    TB10.Hide();
                    TB11.Hide();
                    TB12.Show();
                    TB13.Show();
                    TB14.Show();
                    TB15.Hide();
                    TB16.Hide();
                    TB17.Hide();
                    break;
                case 4:
                    TB3.Hide();
                    TB4.Hide();
                    TB5.Hide();
                    TB6.Hide();
                    TB7.Hide();
                    TB8.Hide();
                    TB9.Hide();
                    TB10.Hide();
                    TB11.Hide();
                    TB12.Hide();
                    TB13.Hide();
                    TB14.Hide();
                    TB15.Show();
                    TB16.Show();
                    TB17.Show();
                    break;

            }

        }

        private void SendRepForm_Load(object sender, EventArgs e)
        {
            MC1.Hide();

            MTB1.Text = MC1.TodayDate.ToShortDateString();


            CM_INN.SelectedIndex = 0;
            CB1.SelectedIndex = 0;

            TB3.Show(); TB3.Text = "0";
            TB4.Show(); TB4.Text = "0";
            TB5.Show(); TB5.Text = "0.0";
            TB6.Hide(); TB6.Text = "0";
            TB7.Hide(); TB7.Text = "0";
            TB8.Hide(); TB8.Text = "0.0";
            TB9.Hide(); TB9.Text = "0";
            TB10.Hide(); TB10.Text = "0";
            TB11.Hide(); TB11.Text = "0.0";
            TB12.Hide(); TB12.Text = "0";
            TB13.Hide(); TB13.Text = "0";
            TB13.Hide(); TB13.Text = "0";
            TB14.Hide(); TB14.Text = "0.0";
            TB15.Hide(); TB15.Text = "0";
            TB16.Hide(); TB16.Text = "0";
            TB17.Hide(); TB17.Text = "0.0";
            
            MySqlCommand com = new MySqlCommand("select INN from project.login_inn where login = '" + Program.ConnectForm.login + "'", Program.ConnectForm.conn);
            MySqlDataReader readed = com.ExecuteReader();
            int count = 0;
            while (readed.Read())
            {
                CM_INN.Items.Insert(count++, readed[0].ToString());
            }

            Program.ConnectForm.conn.Close();
            
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

            string query = "insert into reports value( ' " + TB2.Text + " ', ' " + date.ToString("yyyy.MM.dd") + " ', ' " + TB3.Text + " ', ' " +
                TB4.Text + " ', ' " + TB5.Text + " ', ' " + TB6.Text + " ', ' " + TB7.Text + " ', ' " + TB8.Text + " ', ' " + TB9.Text +
                " ', ' " + TB10.Text + " ', ' " + TB11.Text + " ', ' " + TB12.Text + " ', ' " + TB13.Text + " ', ' " + TB14.Text +
                 " ', ' " + TB15.Text + " ', ' " + TB16.Text + " ', ' " + TB14.Text + " ' )";

            MySqlCommand command = new MySqlCommand(query, Program.ConnectForm.conn);
            command.ExecuteScalar();
        }
    }
}