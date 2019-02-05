using System;
using System.Data;
using System.IO;
using System.Net;
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
            /*while (true)//Проверка интернета
            {
                try
                {        
                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://www.google.ru/");
                    request.UserAgent = "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 5.1)";
                    request.Timeout = 3000;

                    HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                    Stream ReceiveStream1 = response.GetResponseStream();
                    StreamReader sr = new StreamReader(ReceiveStream1, true);
                    string responseFromServer = sr.ReadToEnd();

                    response.Close();
                    break;
                }
                catch
                {
                    DialogResult = MessageBox.Show("Проверьте Ваш фаервол или настройки сетевого подключения", "Ошибка", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    if(DialogResult == DialogResult.Cancel)
                    {
                        Environment.Exit(0);
                    }
                    continue;
                }
            }*/
        }

        private void ButtonConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Validation.StringValidation(Validation.ValidationType.LoginType, TBLogin.Text))
                {
                    MessageBox.Show("Недопустимые символы в логине", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!Validation.StringValidation(Validation.ValidationType.PasswordType, TBPassword.Text))
                {
                    MessageBox.Show("Недопустимые символы в пароле", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (TBLogin.Text != "" && TBPassword.Text != "")
                {
                    if (!Connection.Request(Structs.HOST, "0" + Structs.SEPARATOR_CHAR + JsonConvert.SerializeObject(
                     new Structs.Authentication(TBLogin.Text, TBPassword.Text))))
                    {
                        MessageBox.Show("Отсутствует соединение с сервером.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось подключится к серверу.\n" + ex.Message, "Ошибка подключения", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
