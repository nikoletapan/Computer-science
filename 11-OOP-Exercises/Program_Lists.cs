#define START 
using System;
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lists
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("####### МАСИВИ - преговор с допълнение #######"); //винаги
#if IGNORE  

            // обикновено имената са в мн.ч. numbers, fruirs, cars...
            int[] numbers1v = new int[5]; // нов масив вариант 1: 1v

            int[] numbers2v;  // деклариране
            numbers2v = new int[6]; // 6 елемента, по подразбиране са 0-и

            int[] numbers3v = { 7, 14, 21, 28, 35, 42};

            Console.WriteLine(numbers3v[0]);  // първи елемент 7
            numbers3v[2] = 10;                // промяна на трети елемент 21 -> 10

            for (int i = 0; i < numbers1v.Length; i++) // обхожда елементите
            {
                numbers1v[i] = int.Parse(Console.ReadLine()); // прочита и натрупва
            }

            Console.WriteLine($"{new string('x', 33)} \nРедица 3: ");
            for (int i = 0; i < numbers3v.Length; i++) // обхожда елементите
            {
                Console.Write(numbers3v[i] + " "); // отпечатва
            }
            Console.WriteLine($"\n{new string('#', 33)} \n Редица 3: ");
            foreach (int number in numbers3v)  // друго обхождане
            {
                Console.Write(number + " "); // обикновено е името на масива в ед.ч.
            }
            Console.WriteLine($"\n{new string('x', 33)}");
            double avg1v = (double) SumElements(numbers1v)/numbers1v.Length;
            Console.WriteLine($"Средна стойност: { avg1v}");

            MinMaxValues(numbers3v);

            Console.WriteLine(new string('#', 33));
            Console.WriteLine("Променен елемент: " + string.Join(" ", numbers3v));
            Array.Sort(numbers3v);  // сортира
            Console.WriteLine("След сортиране: " + string.Join(" ", numbers3v));
            Array.Reverse(numbers3v);  // преобръща
            Console.WriteLine("След обръщане: " + string.Join(" ", numbers3v));
            Console.WriteLine("Оригинал: " + string.Join(" ", numbers3v));
            Array.Resize(ref numbers3v, 8);
            Console.WriteLine($"Нов размер: {numbers3v.Length}");
            numbers3v[6] = 9;
            numbers3v[7] = 99;
            Console.WriteLine($"Увеличен размер {string.Join(" ", numbers3v)}");

#else
            Console.Write("Въведете редица: ");

            int[] numbers4v = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Console.WriteLine(numbers4v); // System.Int32[]

            Console.WriteLine(string.Join(' ', numbers4v)); 

            Array.ForEach(numbers4v, x => Console.Write(x));

            Random random = new Random();

            var shuffled = numbers4v.OrderBy(x => random.Next()).ToArray();

            Console.WriteLine("Разбъркан с LINQ: " + string.Join(", ", shuffled));


            int[,] matrix = {
                             {9, 2, 3},  //започват от [0,0] = първи ел.
                             {4, 5, 6},
                             {7, 8, 1}
                            };

            string[,] names = new string[2, 4]; // задава размер

            int element = matrix[1, 2]; // 6 (ред 1, колона 2)

            Console.WriteLine(matrix[0, 0]); // първи ел 9

            matrix[2, 1] = 100; // Променя 8 на 100

            for (int row = 0; row < matrix.GetLength(0); row++)  // обхождане
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }

#endif
            Console.WriteLine("####### КРАЙ - това беше!:) #######"); //винаги
        }

        private static void MinMaxValues(int[] arr)
        {
            int min = arr[0];
            int max = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min) min = arr[i];
                if (arr[i] > max) max = arr[i];
            }

            Console.WriteLine($"Минимум: {min}, максимум: {max}");

            
            List<int> numbers = new List<int>(); // Създаване
            List<string> names = new List<string> { "Иван", "Мария", "Петър" }; // Създаване + инициализиране

            numbers.Add(10); //Добавяне на елементи
            numbers.Add(20);
            numbers.Add(30);

            Console.WriteLine(numbers[0]);  // извежда първия елемент
            numbers[1] = 25;                // промяна на елемент

            numbers.Remove(25);     // премахва първата поява на 25
            numbers.RemoveAt(0);    // премахва елемента на позиция 0
            numbers.Clear();        // изтрива всички елементи

            Console.WriteLine(numbers.Count);  // брой елементи

            for (int i = 0; i < numbers.Count; i++) // Обхождане - вместо .Length -> .Count
            {
                Console.WriteLine(numbers[i]);     // for
            }

            foreach (int number in numbers) // Вместо number може i, x или друго
            {
                Console.WriteLine(number);  // foreach
            }
        }


        private static int SumElements(Array array)
        {
            int sum=0;

            foreach (int element in array)
                sum += element;

            return sum;
        }
           
    }
}
