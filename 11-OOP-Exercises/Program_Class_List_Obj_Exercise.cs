
namespace Class_List_Obj_Exercise
{
    internal class Program
    {
            static void Main()
            {

            List<Book> library = new List<Book>();

                library.Add(new Book("Под игото", "Иван Вазов", 1894, 25.50m));
                library.Add(new Book("Тютюн", "Димитър Димов", 1951, 30.00m));
                library.Add(new Book("Железният светилник", "Димитър Талев", 1952, 28.75m));
                Console.WriteLine("Въведете заглавие, автор, година на издаване и цена:");

                Console.WriteLine("=== БИБЛИОТЕКА ===");
                foreach (Book book in library)
                {
                    book.DisplayBook();
                }

                decimal totalPrice = 0;
                foreach (Book book in library)
                {
                    totalPrice += book.Price;
                }

                decimal maxPrice = library.Max(b => b.Price);
                decimal avgPrice = library.Average(b => b.Price);
                decimal total = library.Sum(b => b.Price);

                
                Book found = library.Find(b => b.Author.ToLower().Contains("им"));
                Book foundStart = library.Find(b => b.Author.StartsWith("Димитър"));
                Book foundEnd = library.Find(b => b.Author.EndsWith("Димов"));
                
            Console.WriteLine($"Маx: {maxPrice}, avg: {avgPrice}, total: {total:F2}");
                Console.WriteLine($"Намерена по автор: {found.Author} - \"{found.Title}\"");
                        
                Console.WriteLine($"\nОбща цена на книгите: {totalPrice:F2}лв");
            }
        }

    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }

        public Book(string title, string author, int year, decimal price)
        {
            Title = title;
            Author = author;
            Year = year;
            Price = price;
        }

        public void DisplayBook()
        {
            Console.WriteLine($"\"{Title}\" от {Author} ({Year}) - {Price:F2}лв");
        }
    }
    public class Grade
    {
        public string Subject { get; set; }
        public double Value { get; set; }
        public DateTime Date { get; set; }

        public Grade(string subject, double value, DateTime date)
        {
            Subject = subject;
            Value = value;
            Date = date;
        }

        public void DisplayGrade()
        {
            Console.WriteLine($"{Subject}: {Value:F2} ({Date:dd.MM.yyyy})");
        }
    }
}

