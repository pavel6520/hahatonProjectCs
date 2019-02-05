using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
