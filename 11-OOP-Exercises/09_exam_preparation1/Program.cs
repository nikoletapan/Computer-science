namespace _09_exam_preparation1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int v = 7; 

            Outside.Add(v);
            Remove(v);

        }
        static void Remove(int r)
        {
            Console.WriteLine($"Метод Remove r - 5 = {r-5}"); ;
        }
    }
}
