namespace Student_11
{
    internal class Program
    {
        static List<Student> school = new List<Student>();

        static void Main(string[] args)
        {
            while (true)
            {
                ShowMenu();

                ChoiceMenu();

                Console.WriteLine("\nНатиснете Enter за връщане към менюто...");
                Console.ReadLine();
                Console.Clear();
            }
        }

        private static void ShowMenu()
        {
            Console.WriteLine(@"УЧИЛИЩЕН ДНЕВНИК:
а) добавяне на ученици;
б) търсене по име;
в) изтриване на ученици;
г) показване на списъка;
д) изход.
СИСТЕМАТА ОЧАКВА ВАШИЯ ИЗБОР: ");
        }

        private static void ChoiceMenu()
        {
            string choice = Console.ReadLine().ToLower(); // char.Parse ''

            switch (choice) // може и директно тук C.RL()
            {
                case "а" or "a":
                    AddStudentMenu();
                    break;
                case "б" or "b":
                    SearchStudentMenu();
                    break;
                case "в" or "w":
                    DeleteStudentMenu();
                    break;
                case "г" or "g":
                    ShowAllStudentsMenu();
                    break;
                case "д" or "d":
                    Console.WriteLine("Изход от системата...");
                    Environment.Exit(0); break; // в Main() - return;
                default:
                    Console.WriteLine("Невалиден избор. Моля, изберете от а) до д).");
                    break;
            }
        }

        static void AddStudentMenu()
        {
            while (true)
            {
                Console.Write("Искате ли да въведете нов ученик? (да/не): ");
                string input = Console.ReadLine().Trim().ToLower();

                if (input == "не")
                    break;
                else if (input == "да")
                    NewStudent();
                else
                    Console.WriteLine("Моля, въведете \"да\" или \"не\".");
            }
        }

        static void NewStudent()
        {
            Student student = new Student();

            Console.Write("Въведете име: ");
            student.Name = Console.ReadLine();

            Console.Write("Въведете клас: ");
            student.Class = Console.ReadLine();
            Console.Write("Въведете номер: ");
            student.Id = Console.ReadLine();
            Console.Write("Оценка по БЕЛ: ");
            student.Bel = double.Parse(Console.ReadLine());
            Console.Write("Оценка по Чужд език: ");
            student.ForeignL = double.Parse(Console.ReadLine());
            Console.Write("Оценка по Математика: ");
            student.Math = double.Parse(Console.ReadLine());
            Console.Write("Оценка по Физика: ");
            student.Phys = double.Parse(Console.ReadLine());
            Console.Write("Оценка по Биология: ");
            student.Bio = double.Parse(Console.ReadLine());
            Console.Write("Оценка по Химия: ");
            student.Chem = double.Parse(Console.ReadLine());

            school.Add(student);
        }

        static void SearchStudentMenu()
        {
            Console.Write("Въведете име за търсене: "); // Връща първия намерен
            string searchName = Console.ReadLine();
            Student foundStudent = school.Find(s => s.Name.Contains(searchName));

            if (foundStudent != null)
            {
                StudentResult(foundStudent);
            }
            else
            {
                Console.WriteLine("Ученик с такова име не е намерен.");
            }
        }

        public static void StudentResult(Student student)
        {
            Console.WriteLine($@"С П Р А В К А
За успеха на {student.Name} от {student.Class} клас, No {student.Id} 
БЕЛ          - {student.Bel:F2}
Чужд език    - {student.ForeignL:F2}
Математика   - {student.Math:F2}
Физика       - {student.Phys:F2}
Химия        - {student.Chem:F2}
Биология     - {student.Bio:F2}
СРЕДЕН УСПЕХ - {student.Average:F2}");
        }

        static void DeleteStudentMenu()
        {
            Console.Write("Въведете име на ученик за изтриване: ");
            string nameToDelete = Console.ReadLine();
            // може да се добави "Сигурни ли сте, че... (да/не)?

            int removedCount = school.RemoveAll(s => s.Name == nameToDelete);

            if (removedCount > 0)
            {
                Console.WriteLine($"Изтрити са {removedCount} ученика с име \"{nameToDelete}\".");
            }
            else
            {
                Console.WriteLine($"Не е намерен ученик с име \"{nameToDelete}\".");
            }
        }

        static void ShowAllStudentsMenu()
        {
            if (school.Count == 0)
            {
                Console.WriteLine("Все още няма въведени ученици.");
                return;
            }

            Console.WriteLine($"\nСПИСЪК НА УЧЕНИЦИТЕ (общо {school.Count}):");
            Console.WriteLine("=".PadRight(50, '='));

            foreach (var student in school)
            {
                Console.WriteLine($"Име: {student.Name}, Клас: {student.Class}, " +
                    $"Номер: {student.Id}, Среден успех: {student.Average:F2}");
            }
        }        
    }

    public class Student
    {
        private double bel, foreignL, math, phys, chem, bio;

        public string Name { get; set; }
        public string Class { get; set; }
        public string Id { get; set; }

        public double Bel
        {
            get { return bel; }
            set
            {
                if (value >= 2.00 && value <= 6.00) bel = value;
                else Console.WriteLine("Невалидна оценка!");
            }
        }

        public double ForeignL
        {
            get { return foreignL; }
            set
            {
                if (value >= 2.00 && value <= 6.00) foreignL = value;
                else Console.WriteLine("Невалидна оценка!");
            }
        }

        public double Math
        {
            get { return math; }
            set
            {
                if (value >= 2.00 && value <= 6.00) math = value;
                else Console.WriteLine("Невалидна оценка!");
            }
        }

        public double Phys
        {
            get { return phys; }
            set
            {
                if (value >= 2.00 && value <= 6.00) phys = value;
                else Console.WriteLine("Невалидна оценка!");
            }
        }

        public double Chem
        {
            get { return chem; }
            set
            {
                if (value >= 2.00 && value <= 6.00) chem = value;
                else Console.WriteLine("Невалидна оценка!");
            }
        }

        public double Bio
        {
            get { return bio; }
            set
            {
                if (value >= 2.00 && value <= 6.00) bio = value;
                else Console.WriteLine("Невалидна оценка!");
            }
        }

        public double Average { get { return (Bel + ForeignL + Math + Phys + Chem + Bio) / 6.0; } }
    }
}