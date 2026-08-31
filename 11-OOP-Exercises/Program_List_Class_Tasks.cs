using System.Diagnostics;

namespace List_Class_Tasks
{
    class Program
    {
        static void Main()
        {
            List<Grade> journal = new List<Grade>();

            journal.Add(new Grade("Математика", 5.75, new DateTime(2024, 1, 15)));
            journal.Add(new Grade("Български", 6.00, new DateTime(2024, 1, 16)));
            journal.Add(new Grade("История", 4.50, new DateTime(2024, 1, 17)));
            journal.Add(new Grade("Математика", 5.25, new DateTime(2024, 1, 18)));

            Console.WriteLine("=== УЧЕНИЧЕСКИ ЖУРНАЛ ===");
            foreach (Grade grade in journal)
            {
                grade.DisplayGrade();
            }

            double average = journal.Average(g => g.Value);
            Console.WriteLine($"\nСреден успех: {average:F2}");

            double mathAverage = journal
                .Where(g => g.Subject == "Математика")
                .Average(g => g.Value);
            Console.WriteLine($"Среден успех по математика: {mathAverage:F2}");
        }
    }
    public class Grade
    {
        public string Subject { get; set; }
        public double Value { get; set; }
        public DateTime Date { get; set; }

        public Grade(string subject, double value, DateTime date)
        {
            Subject = subject;
            Value = value;
            Date = date;
        }

        public void DisplayGrade()
        {
            Console.WriteLine($"{Subject}: {Value:F2} ({Date:dd.MM.yyyy})");
        }
    }
}
