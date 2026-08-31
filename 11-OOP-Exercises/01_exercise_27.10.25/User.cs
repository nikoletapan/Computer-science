using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01_exercise_27._10._25
{
class User
    {
        private string email;
        private string password;
        private string egn;

        public string Email
        {
            get { return email; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Email не може да бъде празен!");

                if (!IsValidEmail(value))
                    throw new ArgumentException("Невалиден email формат!");

                email = value.Trim().ToLower();
            }
        }

        public string Password
        {
            get { return "********"; } // Никога не връщаме реалната парола
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Паролата не може да бъде празна!");

                var validationResult = ValidatePassword(value);
                if (!validationResult.IsValid)
                    throw new ArgumentException(validationResult.ErrorMessage);

                password = HashPassword(value); // Хеширане на паролата
            }
        }

        public string EGN
        {
            get { return egn; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("ЕГН не може да бъде празно!");

                if (!IsValidEGN(value))
                    throw new ArgumentException("Невалидно ЕГН!");

                egn = value.Trim();
            }
        }

         public User(string email, string password, string egn) // конструктор
        {
            Email = email;      // Public - set валидацията
            Password = password;   
            EGN = egn;          
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$"; // нов regex 
                return Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase);
            }
            catch
            {
                return false;
            }
        }

        private (bool IsValid, string ErrorMessage) ValidatePassword(string password)
        {
            if (password.Length < 8)
                return (false, "Паролата трябва да е поне 8 символа!");

            if (!password.Any(char.IsUpper))
                return (false, "Паролата трябва да съдържа поне една главна буква!");

            if (!password.Any(char.IsLower))
                return (false, "Паролата трябва да съдържа поне една малка буква!");

            if (!password.Any(char.IsDigit))
                return (false, "Паролата трябва да съдържа поне една цифра!");

            if (!password.Any(ch => !char.IsLetterOrDigit(ch)))
                return (false, "Паролата трябва да съдържа поне един специален символ!");

            return (true, "");
        }

        private bool IsValidEGN(string egn)
        {
            egn = egn.Trim();

            if (egn.Length != 10) return false;

            if (!egn.All(char.IsDigit)) return false;

            int year = int.Parse(egn.Substring(0, 2)); // части от ЕГН
            int month = int.Parse(egn.Substring(2, 2));
            int day = int.Parse(egn.Substring(4, 2));

            if (month >= 41 && month <= 52) month -= 40; // след 1999

            if (month < 1 || month > 12 || day < 1 || day > 31) return false;

            int[] weights = { 2, 4, 8, 5, 10, 9, 7, 3, 6 }; // контролната цифра
            int sum = 0;

            for (int i = 0; i < 9; i++)
            {
                sum += int.Parse(egn[i].ToString()) * weights[i];
            }

            int remainder = sum % 11;
            int controlDigit = remainder == 10 ? 0 : remainder;
            int actualControlDigit = int.Parse(egn[9].ToString());

            return controlDigit == actualControlDigit;
        }

        private string HashPassword(string password) // демонстрация на хеширане на парола
        {
            // В реална система използвайте BCrypt или подобна библиотека
            return Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(password + "SALT"));
        }

        public bool VerifyPassword(string inputPassword)
        {
            string hashedInput = HashPassword(inputPassword);
            return password == hashedInput;
        }

        public override string ToString()
        {
            return $"Email: {Email}, EGN: {EGN}";
        }
    }
}
