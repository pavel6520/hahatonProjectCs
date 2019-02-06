using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hahatonProjectUser
{
    static class Functions
    {
        /// <summary>
        /// Выводит сообщение об ошибке
        /// </summary>
        public static void ShowError(Structs.Messages error)
        {
            Console.WriteLine();
            Console.WriteLine();

            switch (error)
            {
                case Structs.Messages.BadLogin:
                    MessageBox.Show("Недопустимые символы в логине", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

                case Structs.Messages.BadPassword:
                    MessageBox.Show("Недопустимые символы в пароле", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

                case Structs.Messages.ErrorServerConnection:
                    MessageBox.Show("Отсутствует соединение с сервером.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

                case Structs.Messages.BadLogOrPass:
                    MessageBox.Show("Логин и/или пароль введены неверно.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

                case Structs.Messages.NeedLogOrPass:
                    MessageBox.Show("Введите логин и/или пароль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case Structs.Messages.СompaniesNotFound:
                    MessageBox.Show("На ваш аккаунт не зарегистрировано ни одной компании.\nОбратитесь к администратору.\n", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case Structs.Messages.BadYearFormat:
                    MessageBox.Show("Неверный формат года", "Неверный формат", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

                case Structs.Messages.ErrorSend:
                    MessageBox.Show("Ошибка отправки данных на сервер", "Отправка данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

                case Structs.Messages.SuccessfulSend:
                    MessageBox.Show("Данные успешно отправлены на сервер.", "Отправка данных", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
