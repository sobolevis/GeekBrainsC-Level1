using System;
using System.Collections.Generic;
using System.IO;

struct Account
{
    public readonly string Login;
    public readonly string Password;

    /// <summary>Создать учетную запись</summary>
    /// <param name="login">Логин</param>
    /// <param name="password">Пароль</param>
    public Account(string login, string password)
    {
        Login = login;
        Password = password;
    }
}

namespace Lesson4
{
    class AccountManager
    {
        private List<Account> _accounts = new List<Account>();

        /// <summary>
        /// Создание массива учетных записей (чтение из файла);
        /// </summary>
        /// <param name="filePath"></param>
        public AccountManager(string filePath = "Accounts.txt")
        {
            var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            var streamReader = new StreamReader(fileStream);

            while (!streamReader.EndOfStream)
            {
                try
                {
                    string[] temp;
                    temp = streamReader.ReadLine().Split('|');
                    if (temp.Length != 2) throw new Exception($"Ошибка при чтении!\nПроверьте файл учетных записей. Запись: {temp[0]}");
                    _accounts.Add(new Account(temp[0], temp[1]));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            streamReader.Close();
            fileStream.Close();
        }

        /// <summary>Вывод списка учетных записей</summary>
        public void DisplayMas()
        {
            foreach (Account acc in _accounts)
                Console.WriteLine($"Login: {acc.Login}, password: {acc.Password}");
        }

        /// <summary>Добавление новой учетной записи в файл</summary>
        /// <param name="filePath"></param>
        public void AddAccount(string filePath = "Accounts.txt")
        {

            string login;
            string password;

            Console.WriteLine("Введите логин:");
            login = Console.ReadLine();

            Console.WriteLine("Введите пароль:");
            password = Console.ReadLine();
            
            Account temp = new Account(login, password);
            _accounts.Add(temp);

            var fileStream = new FileStream(filePath, FileMode.Append, FileAccess.Write);
            var streamWriter = new StreamWriter(fileStream);

            streamWriter.Write($"{temp.Login}|{temp.Password}\r\n");

            streamWriter.Close();
            fileStream.Close();
        }



    }
}