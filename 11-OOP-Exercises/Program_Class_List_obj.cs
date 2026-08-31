#define OLD
namespace Class_List_obj
{
    internal class Program
    {
        static void Main(string[] args)
        {
#if OLD
            List<Student> students = new List<Student>();

            string name = "Ivan";
            int age = 17;

            Student s1 = new Student { Name = name, Age = age }; 
            students.Add(s1);
            s1.DisplayInfo();

            Student s2 = new Student { Name = "Peter", Age = 16 };
            students.Add(s2);
            s2.DisplayInfo();
            Console.WriteLine(new string('-', 37));

            foreach (Student student in students)
            {
                student.DisplayInfo();
            }

            Console.WriteLine(new string('#', 37));

            List<Teacher> teachers = new List<Teacher>();

            teachers.Add(new Teacher( "Ivanov", 40 ));
            teachers.Add(new Teacher("Georgieva", 32));
            teachers.Add(new Teacher("Dimitrova", 55));

            foreach (Teacher teacher in teachers)
            {
                teacher.DisplayInfo();
            }

            teachers[0].DisplayInfo(); // първи
            teachers[teachers.Count - 1].DisplayInfo(); // последен

            teachers.Add(new Teacher("Vasileva", 25));
            teachers.Add(new Teacher("Aleksandrov", 60));

            teachers.Insert(3, new Teacher("Evgenieva", 57));
            teachers.Insert(0, new Teacher("Stamov", 44));

            teachers.RemoveAt(0);
            //Teacher toRemove = teachers[0];
            //teachers.Remove(toRemove);

            bool exists = teachers.Exists(t => t.Age < 25);
           Console.WriteLine("Teachers under 25: " + exists);

            Teacher found = teachers.Find( t => t.Name == "Aleksandrov");
            found.DisplayInfo(); // .Find = връща първия намерен елемент        

            double avgAge = teachers.Average(t => t.Age);
            Console.WriteLine($"Average age: {avgAge:F1} years.");

            int maxAge = teachers.Max(t => t.Age);
            Console.WriteLine($"Max age: {maxAge:F1} years."); // по-дълъг запис
            Console.WriteLine($"Max age shorten syntax: {teachers.Max(t => t.Age):F2}"); //директно

            teachers.Add(new Teacher("Aleksandrov", 23));

            List <Teacher> aleks = teachers.FindAll(t => t.Name == "Aleksandrov");
            foreach (Teacher a in aleks) // .FindAll = връща всички срещнати
            {
                Console.WriteLine($"Found by name: {a.Name}, {a.Age}");
            }

            List<Teacher> age25 = teachers.Where(t => t.Age > 25).ToList();
            foreach (Teacher a in age25)
            {
                Console.WriteLine($"Found by age: {a.Name}, {a.Age}");
            }

            List<Teacher> sorted = teachers.OrderBy(t => t.Name).ToList(); // по азбучен ред

            foreach (Teacher teacher in sorted)
            {
                Console.WriteLine(teacher.Name);
            }

            teachers.AddRange(sorted); // добавяме втори списък към първия

            foreach (Teacher teacher in teachers)
            {
                teacher.DisplayInfo();
            }

            
#else
      


#endif
        }
    }
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }

        /*public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }*/

        public void DisplayInfo()
        {
            Console.WriteLine($"Student {Name} is {Age} years old.");
        }
    }
    class Teacher
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Teacher(string name, int age) // ctor
        {
            Name = name;
            Age = age;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Teacher {Name} is {Age} years old.");
        }
    }
}


