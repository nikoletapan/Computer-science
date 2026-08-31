using System;
using System.Linq;

class StringExercise
{
    static void Main()
    {
        string[] products = EnterProducts();

        FindLongestProduct(products);

        List<string> productsWithoutP = PLetterSorting(products);
        
        Capitalize(productsWithoutP);

        Console.WriteLine($"След замяна: {string.Join(", ", products).Replace("старо", "ново")}");
    }

    private static void Capitalize(List<string> productsWithoutP)
    {
       /* List<string> capitalizedProducts = new List<string>();
        foreach (string pwp in productsWithoutP)
        {
            string capitalized = char.ToUpper(pwp[0]) + pwp.Substring(1);
            capitalizedProducts.Add(capitalized);
        } */

        List<string> capitalizedProducts = productsWithoutP
                        .Select(p => 
                            string.IsNullOrEmpty(p) ? p : 
                            char.ToUpper(p[0]) + p.Substring(1))
                        .ToList();

        Console.WriteLine($"Останалите с главна буква: {string.Join(", ", capitalizedProducts)}");
    }

    private static List<string> PLetterSorting(string[] products)
    {
        List<string> productsWithP = new List<string>();
        List<string> productsWithoutP = new List<string>();

        foreach (var p in products)
        {
            if (p.StartsWith("п"))
            {
                productsWithP.Add(p);
            }
            else
            {
                productsWithoutP.Add(p);
            }
        }
        Console.WriteLine($"Продукти започващи с 'п': {string.Join(", ", productsWithP)}");
        return productsWithoutP;
    }

    private static void FindLongestProduct(string[] products)
    {
        string longestProduct = "";
        foreach (var p in products)
        {
            if (p.Length > longestProduct.Length)
            {
                longestProduct = p;
            }
        }
        Console.WriteLine($"Най-дълъг продукт: {longestProduct}");
    }

    private static string[] EnterProducts()
    {
        Console.WriteLine("Въведете списък с продукти, разделени със запетайки:");
        // int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

        string[] products = Console.ReadLine()
            .Split(',') // , StringSplitOptions.RemoveEmptyEntries
            .Select(p => p.Trim().ToLower())
            .ToArray();

        Console.WriteLine($"Всички продукти: {string.Join(", ", products)}");
        Console.WriteLine($"Брой продукти: {products.Length}");
        return products;
    }
}