using System.Text.RegularExpressions;

namespace _03_Regex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            string phonePattern = @"^\+?[0-9\s\-\(\)]{10,}$";

            string urlPattern = @"^(https?:\/\/)?([\da-z\.-]+)\.([a-z\.]{2,6})([\/\w \.-]*)*\/?$";

            // Дата (dd/mm/yyyy)
            string datePattern = @"^(0[1-9]|[12][0-9]|3[01])\/(0[1-9]|1[0-2])\/\d{4}$";

            // Парола (минимум 6 знака, поне една буква и цифра)
            string passwordPattern = @"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{6,}$";



            // 1. Чрез статични методи
            bool match = Regex.IsMatch(input, pattern);

            // 2. Чрез инстанция
            Regex regex = new Regex(pattern);
            bool match = regex.IsMatch(input);

            // 3. С опции
            Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);
        }
    }
}
