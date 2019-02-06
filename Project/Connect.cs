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
        public ConnectForm()
        {
            InitializeComponent();
        }

        private void BT_Connect_Click(object sender, EventArgs e)
        {
            if (!Validation.StringValidation(Validation.ValidationType.LoginType, TBLogin.Text))
            {
                Functions.ShowError(Structs.Messages.BadLogin);
                return;
            }

            if (!Validation.StringValidation(Validation.ValidationType.PasswordType, TBPassword.Text))
            {
                Functions.ShowError(Structs.Messages.BadPassword);
                return;
            }

            if (TBLogin.Text != "" && TBPassword.Text != "")
            {
                if (!Connection.Request(Structs.HOST, "0" + Structs.SEPARATOR_CHAR + JsonConvert.SerializeObject(
                    new Structs.Authentication(TBLogin.Text, TBPassword.Text))))
                {
                    Functions.ShowError(Structs.Messages.ErrorServerConnection);
                    return;
                }

                if (Connection.Response() == "1")
                {
                    Structs.login = TBLogin.Text;
                    Structs.password = TBPassword.Text;
                    Hide();

                    new SendReportForm().Show();
                }
                else
                    Functions.ShowError(Structs.Messages.BadLogOrPass);
            }
            else
            {
                Functions.ShowError(Structs.Messages.NeedLogOrPass);
            }
        }

        private void TB_Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Validation.CharValidation(Validation.ValidationType.LoginType, e.KeyChar, PasteMode: true);
        }

        private void TB_Pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Validation.CharValidation(Validation.ValidationType.PasswordType, e.KeyChar, PasteMode: true);
        }

        private void CB_CheckedChanged(object sender, EventArgs e)
        {
            TBPassword.UseSystemPasswordChar = !checkBox1.Checked;
        }
    }
}
