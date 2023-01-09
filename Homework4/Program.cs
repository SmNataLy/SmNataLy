Console.Write("Ведите число: ");
int num = Convert.ToInt32(Console.ReadLine());

for (int n=1; n<=num; n++)
    if (n % 2 == 0)
       Console.WriteLine(n);