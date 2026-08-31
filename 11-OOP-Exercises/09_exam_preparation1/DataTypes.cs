using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_exam_preparation1
{
    internal class DataTypes
    { /*
        // Цели числа
        byte b = 255;          // 0 до 255 (1 байт)
        sbyte sb = -128;        // -128 до 127 (1 байт)
        short s = -32768;       // -32,768 до 32,767 (2 байта)
        ushort us = 65535;       // 0 до 65,535 (2 байта)
        int i = 2147483647;   // -2.1e9 до 2.1e9 (4 байта)
        uint ui = 4294967295;  // 0 до 4.3e9 (4 байта)
        long l = 9223372036854775807;  // -9.2e18 до 9.2e18 (8 байта)
        ulong ul = 18446744073709551615; // 0 до 1.8e19 (8 байта)

        // Числа с плаваща запетая
        float f = 3.14f;        // ~6-9 цифри (4 байта)
        double d = 3.1415926535; // ~15-17 цифри (8 байта)
        decimal dec = 123.456m;   // 28-29 значими цифри (16 байта)

        // Други
        char c = 'A';          // Unicode символ (2 байта)
        bool flag = true;      // true/false (1 байт)
        string str = "Hello C#";     // Непроменлив низ
        object obj = "Hello World";  // Базов клас за всички типове
        //-------------------------------------------------
        // Nullable
        int? nullableInt = null;          // ? позволява да съдържа null
        Nullable<double> nullableDouble = 3.14;
        DateTime? date = DateTime.Now;
        //-------------------------------------------------
        // тип variable - автоматично се разпознава, но трябва да е вътре в метод
        var name = "John";  // string
        var age = 25;       // int
        //-------------------------------------------------
        // динамичен тип - името се запазва, но типът се променя - също трябва да е в метод
        dynamic value = 10;
        value = "Hello";  // Валидно
        //-------------------------------------------------
        // Масиви - от прости еднотипни данни
        int[] numbers = new int[5] { 1, 2, 3, 4, 5 };
        string[] names = new string[3];
        //-------------------------------------------------
        //Персонален тип enum - ние определяме какво да съдържа
        enum Days { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }
        Days today = Days.Monday;
        //-------------------------------------------------
        // Стеков тип
        struct Point
        {
            public int X;
            public int Y;
        }

        Point p = new Point { X = 10, Y = 20 };
        //-------------------------------------------------
        // Класове - от различни типове данни по шаблон на обект
        class Person
        {
            public string Name;
            public int Age;
        }

        Person person = new Person { Name = "John", Age = 30 };
        //-------------------------------------------------
        // Интерфейси - започват с I, наследяват клас
        class Dog : IAnimal
        {
            public void MakeSound() => Console.WriteLine("Woof!");
        }
        //-------------------------------------------------
        // Делегати
        delegate void MyDelegate(string message);
        MyDelegate del = message => Console.WriteLine(message); 
        */
    }
}
