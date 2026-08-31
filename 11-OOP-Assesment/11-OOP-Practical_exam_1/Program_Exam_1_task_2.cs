Console.WriteLine("Enter a positive numer: ");
int n = int.Parse(Console.ReadLine());
int sum = 0;
int count = 0;

for (int i = 0; i < n; i++)
{
    int temp = int.Parse(Console.ReadLine());

    if(temp > 0) sum += temp;

    count++;
}    