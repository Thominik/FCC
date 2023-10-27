namespace FCCApp
{
    public abstract class Person
    {
        public Person(string name, string surname, char gender, int age)
        {
            Name = name;
            Surname = surname;
            Gender = gender;
            Age = age;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }
        public char Gender { get; private set; }
        public int Age { get; private set; }
    }
}
