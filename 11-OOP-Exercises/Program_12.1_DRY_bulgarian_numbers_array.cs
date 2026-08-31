Console.Write("Въведете число: ");
int num = int.Parse(Console.ReadLine());
string result = ""; 

        if (num == 0)
            result = "Нула";

        if (num < 0 || num > 999)
            throw new ArgumentOutOfRangeException(nameof(num), "Числото трябва да е в интервала [0..999]");

        string[] units = { "", "едно", "две", "три", "четири", "пет", "шест", "седем", "осем", "девет" };
        string[] teens = { "десет", "единадесет", "дванадесет", "тринадесет", "четиринадесет",
                          "петнадесет", "шестнадесет", "седемнадесет", "осемнадесет", "деветнадесет" };
        string[] tens = { "", "", "двадесет", "тридесет", "четиридесет", "петдесет",
                         "шестдесет", "седемдесет", "осемдесет", "деветдесет" };
        string[] hundreds = { "", "сто", "двеста", "триста", "четиристотин", "петстотин",
                             "шестстотин", "седемстотин", "осемстотин", "деветстотин" };

        // Стотици
        int hundredsDigit = num / 100;
        if (hundredsDigit > 0)
        {
            result += hundreds[hundredsDigit];
        }

        // Десетици и единици
        int remainder = num % 100;
        if (remainder > 0)
        {
            if (hundredsDigit > 0)
            {
                result += " ";
            }

            if (remainder < 10)
            {
                // Единици (1-9)
                result += units[remainder];
            }
            else if (remainder < 20)
            {
                // Teen числа (10-19)
                result += teens[remainder - 10];
            }
            else
            {
                // Десетици (20-99)
                int tensDigit = remainder / 10;
                int unitsDigit = remainder % 10;

                result += tens[tensDigit];

                if (unitsDigit > 0)
                {
                    result += " и " + units[unitsDigit];
                }
            }
        }
{
    // Премахване на излишни интервали
    result = result.Trim();
    result = result.Replace("  ", " ");
}
    // Начална главна буква
    if(result.Length > 0) 
        result = char.ToUpper(result[0]) + result.Substring(1);

Console.WriteLine(result);