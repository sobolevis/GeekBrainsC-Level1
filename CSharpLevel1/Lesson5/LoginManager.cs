using System;
using System.Text.RegularExpressions;

namespace Lesson5
{
    class LoginManager
    {
        private string _login;

        /// <summary>Конструктор</summary>
        public LoginManager()
        {
            _login = "";
        }

        /// <summary>Получить логин</summary>
        /// <returns></returns>
        public string GetLogin()
        {
            return _login;
        }

        /// <summary>Задать логин</summary>
        /// <param name="str">Логин</param>
        /// <param name="mode">"Режим" проверки</param>
        public void SetLogin(string str, SetLoginMode mode)
        {
            switch (mode)
            {
                case SetLoginMode.DontUseRegex:
                    if (CheckLoginWithoutRegex(str)) _login = str;
                    break;

                case SetLoginMode.UseRegex:
                    if (CheckLoginWithRegex(str)) _login = str;
                    break;
            }
        }

        /// <summary>Проверить логин без Regex</summary>
        /// <param name="str">Логин</param>
        /// <returns></returns>
        private bool CheckLoginWithoutRegex(string str)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(str)) throw new Exception("Введена пустая строка!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

            if (str.Length > 2 && str.Length < 10 && !char.IsDigit(str[0]))
                for (int i = 1; i < str.Length; i++)
                    if (char.IsLetterOrDigit(str[i]))
                        return true;
                    else
                        return false;
            return false;
        }

        /// <summary>Проверить логин с Regex</summary>
        /// <param name="str">Логин</param>
        /// <returns></returns>
        private bool CheckLoginWithRegex(string str)
        {
            string pattern = @"^[A-z]\w{2, 10}";
            if (Regex.IsMatch(str, pattern)) return true;
            return false;
        }
    }
}

/*
 1. Создать программу, которая будет проверять корректность ввода логина.
Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры, 
при этом цифра не может быть первой:
а) без использования регулярных выражений;
б) с использованием регулярных выражений.
*/