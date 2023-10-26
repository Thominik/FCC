namespace FCCApp
{
    public class Employee
    {
        private List<float> grades = new List<float>();

        public Employee(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }

        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
                grades.Add(grade);
            else
                Console.WriteLine("invalid grade value");
        }

        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
                AddGrade(result);
            else
                Console.WriteLine("String is not a float value");
        }
        
        public void AddGrade(char grade)
        {  
            switch (grade)
            {
                case 'A':
                case 'a':
                    grades.Add(100); 
                    break;
                case 'B':
                case 'b':
                    grades.Add(80);
                    break;
                case 'C':
                case 'c':
                    grades.Add(60);
                    break;
                case 'D':
                case 'd':
                    grades.Add(40);
                    break;
                case 'E':
                case 'e':
                    grades.Add(20);
                    break;
                default:
                    Console.WriteLine("Invalid value");
                    break;
            }
        }

        public void AddGrade(double grade)
        {
            var doubleAsFloat = (float)grade;
            AddGrade(doubleAsFloat);
        }

        public void AddGrade(int grade)
        {
            var intAsFloat = (float)grade;
            AddGrade(intAsFloat);
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }

            statistics.Average /= grades.Count;

            switch(statistics.Average)
            {
                case var average when average >= 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average >= 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;
            }
            
            return statistics;
        }
    }
}
