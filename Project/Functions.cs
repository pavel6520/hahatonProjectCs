using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;

namespace hahatonProjectUser
{
    static class Functions
    {
        /// <summary>
        /// Выводит сообщение об ошибке
        /// </summary>
        public static void ShowError(Structs.Errors error)
        {
            Console.WriteLine();
            Console.WriteLine();

            switch (error)
            {
                case Structs.Errors.BadLogin:
                    MessageBox.Show("Недопустимые символы в логине", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

                case Structs.Errors.BadPassword:
                    MessageBox.Show("Недопустимые символы в пароле", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

                case Structs.Errors.ErrorServerConnection:
                    MessageBox.Show("Отсутствует соединение с сервером.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }

            Console.WriteLine();
            Console.WriteLine();
        }

        /// <summary>
        /// Проверяет состояние подключения к интернету
        /// </summary>
        public static void CheckInternetConnection()
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://www.google.ru/");
                request.UserAgent = "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 5.1)";
                request.Timeout = 3000;

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream ReceiveStream = response.GetResponseStream();

                StreamReader sr = new StreamReader(ReceiveStream, true);
                string responseFromServer = sr.ReadToEnd();

                response.Close();
            }
            catch
            {
                MessageBox.Show("Проверьте Ваш фаервол или настройки сетевого подключения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
