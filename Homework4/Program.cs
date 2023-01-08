Console.Write("Ведите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

for (int n=1; n<=N; n++)
    if (n % 2 == 0)
       Console.WriteLine(n);