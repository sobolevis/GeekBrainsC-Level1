﻿using System;

namespace Lesson5
{
    class Program
    {
        static void Main()
        {
            //Task01();
            //Task02();
            //Task03();
            //Task04();
            Task05();

            Pause();
        }

        public static void Task01()
        {
            LoginManager lg = new LoginManager();

            Console.WriteLine("Введите логин:");
            lg.SetLogin(Console.ReadLine(), SetLoginMode.DontUseRegex);
            Console.WriteLine(lg.GetLogin());

            Console.WriteLine("Введите логин:");
            lg.SetLogin(Console.ReadLine(), SetLoginMode.UseRegex);
            Console.WriteLine(lg.GetLogin());
        }

        public static void Task02()
        {
            var n = 4;
            Console.WriteLine($"Удаление слов, длина которых больше {n}");
            Console.WriteLine(MessageManager.StringLengthLessN(n));
            Console.WriteLine();

            char c = '.';
            Console.WriteLine($"Удаление слов, заканчивающихся на {c}");
            Console.WriteLine(MessageManager.RemoveWordsEndingChar(c));
            Console.WriteLine();

            Console.WriteLine("Поиск самого длинного слова");
            Console.WriteLine(MessageManager.FindLongestWord());
            Console.WriteLine();

            Console.WriteLine("Поиск всех самых длинных слов");
            Console.WriteLine(MessageManager.FindAllLongestWords());
            Console.WriteLine();
        }

        public static void Task03()
        {
            string a = "acdb";
            string b = "cdba";
            Console.WriteLine($"Является ли строка \"{a}\" перестановкой строки \"{b}\": {MessageManager.CheckReplacedStrings(a,b)}");
        }

        public static void Task04()
        {
            Console.WriteLine(SchoolManager.FindAllBadStudent());
        }

        public static void Task05()
        {
            QuestionManager.Game();
        }

        private static void Pause()
        {
            Console.WriteLine("Нажмите любую клавишу");
            Console.ReadKey();
        }

    }
}

/*
1. Создать программу, которая будет проверять корректность ввода логина.
Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры, 
при этом цифра не может быть первой:
    а) без использования регулярных выражений;
    б) с использованием регулярных выражений.

2. Разработать класс Message, содержащий следующие статические методы для обработки текста:
    а) Вывести только те слова сообщения, которые содержат не более n букв.
    б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
    в) Найти самое длинное слово сообщения.
    г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
Продемонстрируйте работу программы на текстовом файле с вашей программой.

3. *Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой. Регистр можно не учитывать:
    а) с использованием методов C#;
    б) * разработав собственный алгоритм.
Например: badc являются перестановкой abcd.

4. Задача ЕГЭ.
На вход программе подаются сведения о сдаче экзаменов учениками 9-х классов некоторой средней школы.
В первой строке сообщается количество учеников N, которое не меньше 10, но не превосходит 100,
каждая из следующих N строк имеет следующий формат:
    <Фамилия> <Имя> <Оценки>, где 
    <Фамилия> — строка, состоящая не более чем из 20 символов, 
    <Имя> — строка, состоящая не более чем из 15 символов, 
    <Оценки> — через пробел три целых числа, соответствующие оценкам по  пятибалльной системе. 
<Фамилия> и <Имя>, а также <Имя> и<оценки> разделены одним пробелом.
Пример входной строки: Иванов Петр 4 5 3
Требуется написать программу, которая будет выводить на экран фамилии и имена трёх худших по среднему баллу учеников. 
Если среди остальных есть ученики, набравшие тот же средний балл, что и один из трёх худших, следует вывести и их фамилии и имена.

5. **Написать игру «Верю.Не верю». В файле хранятся вопрос и ответ, правда это или нет. 
Например: «Шариковую ручку изобрели в древнем Египте», «Да». 
Компьютер загружает эти данные, случайным образом выбирает 5 вопросов и задаёт их игроку.
Игрок отвечает Да или Нет на каждый вопрос и набирает баллы за каждый правильный ответ.
Список вопросов ищите во вложении или воспользуйтесь интернетом.

Достаточно решить 2 задачи. Старайтесь разбивать программы на подпрограммы. 
Переписывайте в начало программы условие и свою фамилию. Все программы сделать в одном решении. 
Для решения задач используйте неизменяемые строки (string)
*/