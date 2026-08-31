namespace _01_strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string first = "Hello,";
            string second = " ";
            string third = "World";
            char symbol = '!';

            string concatenation = first + second + third + symbol;

            Console.WriteLine(concatenation);

            Console.WriteLine(new string('-', 33));

            string emptyTest = "";
            string emptyTest1 = string.Empty;

            Console.WriteLine(first.Length); // 6
            Console.WriteLine(second.Length); // 1
            Console.WriteLine(emptyTest.Length);  //0

            Console.WriteLine(new string('-', 33));
            string asd = "Алгоритми и структури от данни";

            Console.WriteLine(asd[0]); // А
            Console.WriteLine(asd[3]); // о 
            Console.WriteLine(asd[asd.Length-1]); // и - последно
            Console.WriteLine($"\"{asd[asd.Length-6]}\""); // интервал

            Console.WriteLine(new string('-', 33));

            string mathematics = "Mathematics";
            string informatics = "Informatics";
            Console.WriteLine(mathematics + " & " + informatics);

            Console.WriteLine(mathematics.ToUpper());
            Console.WriteLine(mathematics.ToLower());

            Console.WriteLine(mathematics.Substring(8));
            Console.WriteLine(mathematics.Substring(4, 3));

            bool mat = mathematics.Contains("mat");  // true
            Console.WriteLine(mat);

            Console.WriteLine(mathematics.IndexOf("ema"));  // от 4
            Console.WriteLine(mathematics.IndexOf("info")); // -1 - не съдържа 

            Console.WriteLine(mathematics.Remove(0, 3));  // hematics

            Console.WriteLine(asd.IndexOf("структури")); // 12
            
            Console.WriteLine(concatenation.Replace("World", "XI class"));

            string apple = "Червена ябълка";
            Console.WriteLine(apple.Replace("Червена", "Зелена"));

            Console.WriteLine("a-b-c".Replace('-', '_'));  //a_b_c

            string guess = "Триъгълник";
            Console.WriteLine(guess.Replace('и', '!'));    //Тр!ъгълн!к
            Console.WriteLine(mathematics.Replace("at", "*"));  //M*hem*ics

            Console.WriteLine(new string('-', 33));

            string[] names = { "Ние", "сме", "в", "XI", "клас" };
            Console.WriteLine(string.Join(" ", names));

            string student = "Мария,математика,5.50";
            string[] data = student.Split(',');
            Console.WriteLine($"Ученик: {data[0]}, предмет {data[1]}, оценка {data[2]}");

            foreach (var d in data) Console.Write(d + '_');
            Console.WriteLine();
            Console.WriteLine(string.Join(", ", data));

            string longText = "Това, е; последният -пример.за този час.";
            char[] separators = { ' ', ',', ';', '-', '.' };
            string[] words = longText.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(string.Join(' ', words));

            string s = "11 клас, събудете се!";

            string s = new string('#', 33);
        }
    }
}
