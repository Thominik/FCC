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
            if (char.IsDigit(grade))
                AddGrade((float)char.GetNumericValue(grade));
            else
                Console.WriteLine("Char is not a float value");
        }

        public void AddGrade(double grade)
        {
            if (float.TryParse(grade.ToString(), out float result))
                AddGrade(result);
            else
                Console.WriteLine("Double is not a float value");
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
            
            return statistics;
        }

        public Statistics GetStatisticsWithForEach()
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

            return statistics;
        }

        public Statistics GetStatisticsWithFor()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            for (int i = 0; i < grades.Count; i++)
            {
                var grade = grades[i];
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }

            statistics.Average /= grades.Count;

            return statistics;
        }

        public Statistics GetStatisticsWithDoWhile()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            var quantity = 0;

            do
            {
                statistics.Max = Math.Max(statistics.Max, grades[quantity]);
                statistics.Min = Math.Min(statistics.Min, grades[quantity]);
                statistics.Average += grades[quantity];
                quantity++;
            } while (grades.Count > quantity);

            statistics.Average /= grades.Count;
            return statistics;
        }

        public Statistics GetStatisticsWithWhile()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            var quantity = 0;

            while (grades.Count > quantity)
            {
                statistics.Max = Math.Max(statistics.Max, grades[quantity]);
                statistics.Min = Math.Min(statistics.Min, grades[quantity]);
                statistics.Average += grades[quantity];
                quantity++;
            }

            statistics.Average /= grades.Count;
            return statistics;
        }
    }
}
