Console.Write("Въведете число: ");
int num = int.Parse(Console.ReadLine());
string result = ""; 

if (num == 0)  result = "Нула";
        if (num < 0 || num > 999)
            throw new ArgumentOutOfRangeException(nameof(num), "Числото трябва да е в интервала [0..999]");

        // Стотици
        int hundreds = num / 100;
        if (hundreds > 0)
        {
            result += hundreds switch
            {
                1 => "сто",
                2 => "двеста",
                3 => "триста",
                4 => "четиристотин",
                5 => "петстотин",
                6 => "шестстотин",
                7 => "седемстотин",
                8 => "осемстотин",
                9 => "деветстотин",
                _ => ""
            };
        }

        // Десетици и единици
        int remainder = num % 100;
        if (remainder > 0)
        {
            if (!string.IsNullOrEmpty(result))
                result += " ";

            if (remainder > 10 && remainder < 20)
            {
                // Teen числа
                result += (remainder - 10) switch
                {
                    0 => "десет",
                    1 => "единадесет",
                    2 => "дванадесет",
                    3 => "тринадесет",
                    4 => "четиринадесет",
                    5 => "петнадесет",
                    6 => "шестнадесет",
                    7 => "седемнадесет",
                    8 => "осемнадесет",
                    9 => "деветнадесет",
                    _ => ""
                };
            }
            else
            {
                // Десетици
                int tens = remainder / 10;
                int units = remainder % 10;

                result += tens switch
                {
                    2 => "двадесет",
                    3 => "тридесет",
                    4 => "четиридесет",
                    5 => "петдесет",
                    6 => "шестдесет",
                    7 => "седемдесет",
                    8 => "осемдесет",
                    9 => "деветдесет",
                    _ => ""
                };


                if (units > 0)
                {

                    if (remainder > 10) result += " и ";

                    result += (units switch
                    {
                        1 => "едно",
                        2 => "две",
                        3 => "три",
                        4 => "четири",
                        5 => "пет",
                        6 => "шест",
                        7 => "седем",
                        8 => "осем",
                        9 => "девет",
                        _ => ""
                    });
                }
            }
        }

        // Първа буква главна
        if (!string.IsNullOrEmpty(result))
        {
            result = char.ToUpper(result[0]) + result.Substring(1);
        }

Console.WriteLine(result);