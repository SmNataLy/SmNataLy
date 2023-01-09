Console.Write("Ведите переменную а: ");
int a = Int32.Parse(Console.ReadLine());

if (a % 2 == 0)
{
    Console.WriteLine(a + "- четное число: ");
}
else
{
    Console.WriteLine(a + "- нечетное число: ");
}
