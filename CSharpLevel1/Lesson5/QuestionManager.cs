using System;
using System.Collections.Generic;
using System.IO;

namespace Lesson5
{
    class QuestionManager
    {
        private static List<string> _questions = new List<string>();

        /// <summary>Игра</summary>
        public static void Game()
        {
            ReadQuestionsFile();
            Random rnd = new Random();
            int score = 0;
            int n = 5;
            Console.WriteLine("Давай сыграем в игру!\r\nЯ буду задавать вопросы, а ты отвечай \"Да\" или \"Нет\"");
            for (int i = 0; i < n; i++)
            {
                string[] currQuestion = _questions[rnd.Next(_questions.Count)].Split('|');
                Console.WriteLine(currQuestion[0]);
                string answer = Console.ReadLine();
                if (answer.ToUpper() == currQuestion[1].ToUpper())
                {
                    Console.WriteLine("Верно!");
                    score++;
                }
                else
                {
                    Console.WriteLine("Неверно =(");
                }
            }

            Console.WriteLine($"Ты набрал {score} очков из {n}.");
        }

        /// <summary>Считать все вопросы из файла</summary>
        /// <param name="fileName"></param>
        private static void ReadQuestionsFile(string fileName = "Questions.txt")
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                while (!reader.EndOfStream)
                {
                    _questions.Add(reader.ReadLine());
                }
            }
        }
    }
}

/*
 5. ** Написать игру «Верю. Не верю». В файле хранятся вопрос и ответ, правда это или нет.
Например: «Шариковую ручку изобрели в древнем Египте», «Да». 
Компьютер загружает эти данные, случайным образом выбирает 5 вопросов и задаёт их игроку.
Игрок отвечает Да или Нет на каждый вопрос и набирает баллы за каждый правильный ответ.
Список вопросов ищите во вложении или воспользуйтесь интернетом.
*/