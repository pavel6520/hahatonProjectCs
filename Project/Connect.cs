using System;
using System.Data;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
namespace hahatonProjectUser
{
    public partial class ConnectForm : Form
    {
        public MySqlConnection conn;
        public string ConnectAddress;
        public string ConnectPort;
        public string NameDB;
        public string login;        

        public ConnectForm()
        {
            InitializeComponent();
        }

        private void ConnectForm_Load(object sender, EventArgs e)
        {
            /*Task.Factory.StartNew(() => 
            {
                while (true)
                {
                    Functions.CheckInternetConnection();                    
                }
            });/*            
        }

        private void ButtonConnect_Click(object sender, EventArgs e)
        {
            if (!Validation.StringValidation(Validation.ValidationType.LoginType, TBLogin.Text))
            {
                Functions.ShowError(Structs.Errors.BadLogin);
                return;
            }

            if (!Validation.StringValidation(Validation.ValidationType.PasswordType, TBPassword.Text))
            {
                Functions.ShowError(Structs.Errors.BadPassword);
                return;
            }

            if (TBLogin.Text != "" && TBPassword.Text != "")
            {
                if (!Connection.Request(Structs.HOST, "0" + Structs.SEPARATOR_CHAR + JsonConvert.SerializeObject(
                    new Structs.Authentication(TBLogin.Text, TBPassword.Text))))
                {
                    Functions.ShowError(Structs.Errors.ErrorServerConnection);
                    return;
                }

                if (Connection.Response() == "1")
                {
                    login = TBLogin.Text;
                    Hide();

                    new SendReportForm().Show();
                }
                else
                    MessageBox.Show("Данные введены неверно");
            }
            else
            {
                MessageBox.Show("Введите логин и пароль");
            }
        }

        private void TBLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Validation.CharValidation(Validation.ValidationType.LoginType, e.KeyChar, PasteMode: true);
        }

        private void TBPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Validation.CharValidation(Validation.ValidationType.PasswordType, e.KeyChar, PasteMode: true);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            TBPassword.UseSystemPasswordChar = !checkBox1.Checked;
        }
    }
}
