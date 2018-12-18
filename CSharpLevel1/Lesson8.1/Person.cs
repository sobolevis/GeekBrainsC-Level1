namespace Lesson8._1
{
    public class Person
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Birthday { get; set; }
        public string Interests { get; set; }

        public Person () {}

        public Person(string firstName, string secondName, string birthday, string interests)
        {
            FirstName = firstName;
            SecondName = secondName;
            Birthday = birthday;
            Interests = interests;
        }
    }
}
