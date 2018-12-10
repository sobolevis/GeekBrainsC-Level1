using System;

namespace Lesson6
{
    class Student
    {
        public string FirstName { get; }
        public string SecondName { get; }
        public string Age { get; }
        public string Univercity { get; }
        public string Faculty { get; }
        public string Departament { get; }
        public string Cource { get; }
        public string Group { get; }
        public string City { get; }

        public Student(string[] data)
        {
            if (data == null) throw new ArgumentNullException(nameof(data));
            if (data.Length != 9) throw new ArgumentException("Размер массива данных не равен 9");

            FirstName = data[0];
            SecondName = data[1];
            Age = data[2];
            Univercity = data[3];
            Faculty = data[4];
            Departament = data[5];
            Cource = data[6];
            Group = data[7];
            City = data[8];
        }
    }
}
