using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_exercise_27._10._25
{
    internal class PersonLambda
    {
        private DateTime birthDate;
        public DateTime BirthDate
        {
            get => birthDate;
            set => birthDate = value;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Read-only свойства - вместо get с =>
        public string FullName => $"{FirstName} {LastName}";
        public int Age => DateTime.Now.Year - birthDate.Year;
        public bool IsAdult => Age >= 18;

        public PersonLambda(string firstName, string lastName, DateTime birthDate)
        {
            FirstName = firstName;
            LastName = lastName;
            this.birthDate = birthDate;
        }
    }
}
