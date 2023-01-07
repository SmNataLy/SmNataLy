//int a = 5;
//int b = 7;

//int a = 2;
//int b = 10;
class Tesr
{
    static void Main()
    {
        Console.Write("Ведите переменную а: ");
        int a = Int32.Parse(Console.ReadLine());
        Console.Write("Ведите переменную b: ");
        int b = Int32.Parse(Console.ReadLine());

        if (a > b)
        {
            Console.Write("max=");
            Console.WriteLine(a);
            Console.Write("min=");
            Console.WriteLine(b);
        }
        else
        {
            Console.Write("max=");
            Console.WriteLine(b);
            Console.Write("min=");
            Console.WriteLine(a);
        }
    }
}
