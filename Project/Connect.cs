using System;
using System.Data;
using System.IO;
using System.Net;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
namespace hahatonProjectUser
{
    /*struct Report
    {
        string INN;
        public int FM1, FM2, GF1, GF2, CKR1, CKR2, CPP1, CPP2, CE1, CE2;
        public double FM3, GF3, CKR3, CPP3, CE3;

        public Report(string inn, int fm1, int fm2, double fm3, int gf1, int gf2, double gf3, int ckr1, int ckr2,
            double ckr3, int cpp1, int cpp2, double cpp3, int ce1, int ce2, double ce3)
        {
            INN = inn;

            FM1 = fm1;
            FM2 = fm2;
            FM3 = fm3;

            GF1 = gf1;
            GF2 = gf2;
            GF3 = gf3;

            CKR1 = ckr1; 
            CKR2 = ckr2; 
            CKR3 = ckr3;

            CPP1 = cpp1;
            CPP2 = cpp2;
            CPP2 = cpp2;
            CPP3 = cpp3;

            CE1 = ce1;
            CE2 = ce2;
            CE3 = ce3;
        }
    }*/

    struct Authentication
    {
        public string Login, Password;

        public Authentication(string log, string pass)
        {
            Login = log;
            Password = pass;
        }
    }

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
                    if (!Connection.Request(Program.host, "0" + Program.SeparatorChar + JsonConvert.SerializeObject(
                     new Authentication(TBLogin.Text, TBPassword.Text))))
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

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
