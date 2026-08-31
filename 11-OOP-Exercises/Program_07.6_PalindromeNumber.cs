namespace _07._6_PalindromeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number to check is it a palindrome: ");
            string input = Console.ReadLine();

            while (input != "END")
            {
                Palindrome(input);

                input = Console.ReadLine();
            }
        }
        static void Palindrome(string input)
        {
            bool isPalindrome = false;

            for (int i = 0; i < input.Length / 2; i++)
            {
                if (input[i] != input[input.Length - i - 1])
                {
                    isPalindrome = false;
                }
                else
                    isPalindrome = true;
            }
            Console.WriteLine(isPalindrome.ToString().ToLower());
        }
    }
}
