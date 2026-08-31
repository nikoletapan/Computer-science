namespace Arrays_Lists_A_class
{
    internal class Program
    {
        static void Main()
        {
            List<string> vegetables = new List<string>();

            Console.Write("Въведете брой зеленчуци: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Зеленчук номер: {i+1}");
                vegetables.Add(Console.ReadLine());
            }

            Console.WriteLine(vegetables.Contains("лук") ? "Да" : "Не");
            vegetables.Add("морков");
            vegetables.Insert(1, "чушка");

            Console.WriteLine("Зеленчуци: " + string.Join(", ", vegetables));
            Console.WriteLine("Брой преди отстраняване: " + vegetables.Count);
            vegetables.Remove("чушка");
            Console.WriteLine("Брой след отстраняване: " + vegetables.Count);
         
            vegetables.RemoveAll(x => x == "домат"); //x.Contains("домат")
            Console.WriteLine("Зеленчуци: " + string.Join(", ", vegetables));
            
            vegetables.Contains("чушка");
            Console.WriteLine("Зеленчуци: " + string.Join(", ", vegetables.Find(x => x.Length < 4)));
            Console.WriteLine("Въведете планини: ");
            List<string> mountains = Console.ReadLine().Split(", ").ToList();

            Console.WriteLine("Списък с планини: " + string.Join(", ", mountains));
        }
    }
}
