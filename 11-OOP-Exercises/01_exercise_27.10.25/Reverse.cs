using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_exercise_27._10._25
{
    public class Reverse
    {
        public static void Chars()
        {
            Console.Write("Въведете символи:");
            char[] text = Console.ReadLine().ToCharArray();
            Console.Write("Обърнати символи ");
            for (int i = text.Length - 1; i >= 0; i--)
                Console.Write(text[i]);
        }
        public static void Text()
        {
            Console.Write("\nВъведете текст:");
            string input = Console.ReadLine();  // може на 1 ред
            char[] text = input.ToCharArray(); // да се обединят двата реда
            Array.Reverse(text);               // Вграден метод
            string reversed = new string(text);
            Console.WriteLine("Reversed text: " + reversed);
        }
        public static void Words()
        {
            Console.WriteLine("Въведете думи");
            var words = Console.ReadLine().Split(' ').ToArray(); // Trim()
            for (int i = 0; i < words.Length / 2; i++)
            {
                var temp = words[i];
                words[i] = words[words.Length - 1 - i];
                words[words.Length - 1 - i] = temp;
            }

            Console.WriteLine(string.Join(" ", words));
        }
        public static void NumberArrays1()
        {
            Console.WriteLine("Въведете редица от числа, разделени с интервали:");
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.Write("Числата наобратно: ");
            for (int i = input.Length - 1; i >= 0; i--)
            {
                Console.Write(input[i] + " ");
            }            
        }
        public static void NumberArrays2()
        {
        Console.WriteLine("\nВъведете редица от числа, разделени с тирета:");
        int[] input = Console.ReadLine().Split('-').Select(int.Parse).ToArray();

        Array.Reverse(input);
        Console.WriteLine("Числата наобратно:");
        Console.WriteLine(string.Join("-", input));
    }
        public static void NumberArrays3()
        {
            Console.WriteLine("Въведете редица от числа, разделени със запетайки:");
            int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[] output = new int[input.Length];
            for (int i = input.Length - 1, j = 0; i >= 0; i--, j++)
            {
                output[j] = input[i];
            }
            Console.WriteLine("Числата наобратно:");
            Console.WriteLine(string.Join(", ", output));
        }
    }
}
