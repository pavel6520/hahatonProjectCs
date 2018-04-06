using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Project
{
    public partial class ConnectForm : Form
    {
        public MySqlConnection conn;
        public SendRepForm ReportForm;
        public SettingsForm SetForm;

        public ConnectForm()
        {
            InitializeComponent();
        }

        private void ConnectForm_Load(object sender, EventArgs e)
        {
            if(!Program.IF.KeyExists("ConnSett", "Adress") || !Program.IF.KeyExists("ConnSett", "DBname"))
            {
                SetForm = new SettingsForm();
                this.Hide();
                MessageBox.Show("Педор нахуя ты файл настроек дельнул?\n Ебись теперь все конем.\n" +
                    "Вводи рукожопая тварь все заново");
                SetForm.FormClosing += (obj, arg) =>
                {
                    this.Show();
                };
                SetForm.ShowDialog();
            }
        }

        bool God(KeyPressEventArgs n, char c)
        {
            if (!(Char.IsDigit(n.KeyChar)) && n.KeyChar != 8)
                return false;
            else return true;
        }

        private void ButtonConnect_Click(object sender, EventArgs e)
        {
            //if (TBLogin.Text != "" && TBPass.Text != "")
            //{
                //conn = new MySqlConnection("server=localhost;user=" + TBLogin.Text + ";database=project;password=" + TBPass.Text + ";");
                conn = new MySqlConnection("server=localhost;user= root;database=project;password=121958;");
                conn.Open();
                //conn.ChangeDatabase("db");
                //String query = "insert into test_p.rep values( '" + TB1.Text + "', " + " '" + TB2.Text + "' )";                
                //MySqlCommand command = new MySqlCommand(query, conn); 
                //command.ExecuteScalar();

                if(conn.State == ConnectionState.Open)
                {
                    ReportForm = new SendRepForm();
                    this.Visible = false;
                    ReportForm.Show();
                }
            //}
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetForm = new SettingsForm();
            this.Hide();
            SetForm.FormClosing += (obj, arg) =>
            {
                this.Show();
            };
            SetForm.ShowDialog();
        }

    }
}
