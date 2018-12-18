using System;

namespace Converter
{
    public class Person
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Age { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public Person() { }

        public Person(string[] info)
        {
            if (info == null) throw new Exception("Пустой массив данных");
            if (info.Length != 6) throw new Exception("Неверный формат данных.\nКоличество полей не равно 6.");
            FirstName = info[0];
            SecondName = info[1];
            Age = info[2];
            City = info[3];
            PhoneNumber = info[4];
            Email = info[5];
        }
    }
}
