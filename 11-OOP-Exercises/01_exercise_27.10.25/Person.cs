using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_exercise_27._10._25
{
    internal class Person
    {
        private string firstName;
        private string lastName;
        private int age; 
        private string EGN;
        
        public string FirstName
        {
            get { return firstName; }
            set { if (firstName == null) Console.WriteLine("Не сте въвели име!"); //string.Empty
                  else firstName = value; }
        }
        public string LastName
        { 
            get { return lastName; } 
            set { if (string.IsNullOrWhiteSpace(value)) throw new ArgumentOutOfRangeException("Empty field!");
                else lastName = value; } 
        }
        public int Age
        {
            get { return age; }
            set { if (age < 0 || age > 120) throw new ArgumentOutOfRangeException("Invalid age!");
                  else age = value; } }

        public void Identity()
        {
            Console.WriteLine($"First Name: {FirstName, -15} Last Name: {LastName, -15} Age: {Age}");
        }
    }
}
