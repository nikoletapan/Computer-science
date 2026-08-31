namespace _04_products_array_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Въведете брой продукти: "); // непреподъчителен подход, но често срещан
            int n = int.Parse(Console.ReadLine());

            string[] products = new string[n];

            for (int i = 0; i < n; i++) 
            {
                products[i] = Console.ReadLine();
            } 
            
            string input = Console.ReadLine(); 
             */

            Console.WriteLine("Въведете списък с продукти: ");      

            string[] products = Console.ReadLine()
            .Split(',', StringSplitOptions.RemoveEmptyEntries)
            .Select(x => x.Trim().ToLower())
            .ToArray();

            Console.WriteLine($"Пълният списък е: {string.Join(", ", products)}");

            Console.WriteLine($"Общият брой е: {products.Length}");

            string longestProduct = string.Empty; // "";
            foreach (var p in products)
            {
                if( p.Length > longestProduct.Length )
                {
                    longestProduct = p;
                }
            }

            Console.WriteLine($"Най-дългият продукт е: {longestProduct} с дължина: {longestProduct.Length} букви");

            List<string> pStartingProducts = new List<string>();

            foreach (var p in products)
            {
                if(p.StartsWith("п"))
                {
                    pStartingProducts.Add(p);
                }    
            }

            Console.WriteLine($"Всички продукти, започващи с 'п' са: {string.Join(", ", pStartingProducts)}");

            List<string> replaced = new List<string>();

            Console.WriteLine($"Списък без стари продукти: ");
        }
    }
}
