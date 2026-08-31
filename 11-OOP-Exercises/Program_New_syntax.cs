namespace New_syntax
{
    public class Student
    {
        private readonly string name;
        private readonly int age;
        private readonly double grade;
        private readonly List<string> subjects;

        public string Name => name;
        public int Age => age;
        public double Grade => grade;
        public IReadOnlyList<string> Subjects => subjects.AsReadOnly();
        public string Status => CalculateStatus();

        public Student(string name, int age, double grade)
        {
            // Валидация
            this.name = string.IsNullOrWhiteSpace(name)
                ? throw new ArgumentException("Името не може да е празно")
                : name;

            this.age = age >= 6 && age <= 100
                ? age
                : throw new ArgumentException("Възрастта трябва да е между 6 и 100");

            this.grade = grade >= 2 && grade <= 6
                ? grade
                : throw new ArgumentException("Оценката трябва да е между 2 и 6");

            this.subjects = new List<string>();
        }

        public void AddSubject(string subject)
        {
            if (!string.IsNullOrWhiteSpace(subject) && !subjects.Contains(subject))
                subjects.Add(subject);
        }

        public void RemoveSubject(string subject)
        {
            subjects.Remove(subject);
        }

        private string CalculateStatus()
        {
            return grade switch
            {
                >= 5.50 => "Отличен",
                >= 4.50 => "Много добър",
                >= 3.50 => "Добър",
                _ => "Слаб"
            };
        }

        public override string ToString()
        {
            return $"{Name}, {Age}г., {Grade:F2} ({Status})";
        }
    }
}
