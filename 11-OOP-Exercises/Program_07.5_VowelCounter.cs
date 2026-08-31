namespace _07._5_VowelCounter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a word: ");
            string input = Console.ReadLine().ToLower();

            Console.WriteLine($"The vowels are {VowelCounter(input)}");
        }

        static int VowelCounter(string word)
        {
            int counter = 0;

            for (int i = 0; i < word.Length; i++)
            {
                switch (word[i])
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                    case 'y': counter++; break;
                }
            }
            return counter;
        }
    }
}

