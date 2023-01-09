
Console.Write("Ведите переменную а: ");
int a = Int32.Parse(Console.ReadLine());
Console.Write("Ведите переменную b: ");
int b = Int32.Parse(Console.ReadLine());
Console.Write("Ведите переменную c: ");
int c = Int32.Parse(Console.ReadLine());
int max = a;


if (b > max) max = b;
if (c > max) max = c;

Console.Write("max=");
Console.WriteLine(max);
