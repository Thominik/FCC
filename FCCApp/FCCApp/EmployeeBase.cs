﻿namespace FCCApp
{
    public abstract class EmployeeBase : IEmployee
    {
        public EmployeeBase(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }
        public char Gender { get; private set; }

        public abstract void AddGrade(float grade);

        public abstract void AddGrade(double grade);

        public abstract void AddGrade(int grade);

        public abstract void AddGrade(char grade);

        public abstract void AddGrade(string grade);

        public abstract Statistics GetStatistics();
    }
}
