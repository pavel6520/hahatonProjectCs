using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hahatonProjectUser
{
    static class Structs
    {
        static public ConnectForm ConnectForm;
        static public IniFile IF;
        static public readonly char SEPARATOR_CHAR = '&';
        static public readonly string HOST = "http://localhost:8888/";
        public static string login;
        public static string password;

        /// <summary>
        /// Представляет константы для типов ошибок
        /// </summary>
        public enum Errors
        {
            BadLogin,
            BadPassword,
            ErrorServerConnection,
            BadLogOrPass,
            NeedLogOrPass,
            СompaniesNotFound,
        }

        public struct Authentication
        {
            public string Login, Password;

            public Authentication(string log, string pass)
            {
                Login = log;
                Password = pass;
            }
        }

        public struct Report
        {
            public string inn;
            public int quarter;
            public int year;

            public int[] param1;
            public int[] param2;
            public double[] param3;
        }

        public struct INN_Comp
        {
            public struct Body_Element
            {
                public string INN, Comp_name;

                public Body_Element(string inn, string name)
                {
                    INN = inn;
                    Comp_name = name;
                }
            }

            public List<Body_Element> body;

            public INN_Comp(List<Body_Element> mas)
            {
                body = mas;
            }
        }

    }
}
