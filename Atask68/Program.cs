// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

double FunctionA(double m, double n)
{
    if (m == 0)
        return n + 1;
    else if (m > 0 && n == 0)
        return FunctionA(m - 1, 1);
    else return FunctionA(m - 1, FunctionA(m, n - 1));
}
Console.WriteLine(FunctionA(2, 3));