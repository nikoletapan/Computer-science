Console.WriteLine("\n\tВарианти за учениците от XI В клас, II гр:");
Console.WriteLine("\t=========================================");

int startNo = 14; 
int variants = 14;

char[] letters = new char[variants]; //масив с 14 елемента
for (int i = 0; i < variants; i++)
{
    letters[i] = (char)('А' + i); // кирилица
}

Random random = new Random();  // псевдослучайни

char[] task1 = letters.OrderBy(x => random.Next()).ToArray();
char[] task2 = letters.OrderBy(x => random.Next()).ToArray();

for (int i = 0; i < variants; i++)
{
    int studentNumber = startNo + i;
    char t1 = task1[i];
    char t2 = task2[i];

    Console.WriteLine($"\t♦\tNo {studentNumber} решава 1 {t1}) , 2 {t2})\t♦\t");
}
Console.WriteLine("\t=========================================");
Console.WriteLine($"\t☻\t{DateTime.Now}\tУспех!\t\u263B");