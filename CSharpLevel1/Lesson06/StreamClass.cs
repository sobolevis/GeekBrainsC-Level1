using System;
using System.IO;

namespace Lesson6
{
    class StreamClass
    {
        private string _fileName = "FileForStream.txt";

        /// <summary>
        /// Чтение файла с помощью StreamReader
        /// </summary>
        public void StreamReaderMethod()
        {
            Console.WriteLine("Вывод текста строками");
            using (StreamReader streamReader = new StreamReader(_fileName))
            {
                while (!streamReader.EndOfStream)
                {
                    string temp = streamReader.ReadLine();
                    Console.WriteLine(temp);
                }
            }
        }

        /// <summary>
        /// Чтение файла с помощью BufferedStream
        /// </summary>
        public void BufferedStreamMethod()
        {
            Console.WriteLine("Вывод текста в виде потока байтов - 1 буква - 6 цифр");
            using (FileStream fileStream = new FileStream(_fileName, FileMode.Open, FileAccess.Read, FileShare.Read))
            using (BufferedStream bufferedStream = new BufferedStream(fileStream))
            {
                while (bufferedStream.Position != bufferedStream.Length)
                {
                    int temp = bufferedStream.ReadByte();
                    if (temp == 13 || temp == 32)
                    {
                        Console.Write(" ");
                        continue;
                    }
                    if (temp == 10)
                    {
                        Console.WriteLine();
                        continue;
                    }
                    Console.Write(temp);
                }
            }
        }

        /// <summary>
        /// Чтение файла с помощью BinaryReader
        /// </summary>
        public void BinaryReaderMethod()
        {
            Console.WriteLine("Вывод текста посимвольно - 1 буква - 4 цифры");
            using (FileStream fileStream = new FileStream(_fileName, FileMode.Open, FileAccess.Read, FileShare.Read))
            using (BinaryReader binaryReader = new BinaryReader(fileStream))
            {
                while (binaryReader.PeekChar() > -1)
                {
                    int temp = binaryReader.Read();
                    if (temp == 13 || temp == 32)
                    {
                        Console.Write(" ");
                        continue;
                    }
                    if (temp == 10)
                    {
                        Console.WriteLine();
                        continue;
                    }
                    Console.Write(temp);

                }
            }
        }

    }
}

/*
4.** Считайте файл различными способами.Смотрите “Пример записи файла различными способами”. 
Создайте методы, которые 
    возвращают массив byte (FileStream, BufferedStream), 
    строку для StreamReader, 
    массив int для BinaryReader.
*/
