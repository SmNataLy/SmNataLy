// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.


(double, double)  IntersectionPoint(double k1, double b1, double k2, double b2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    return (x, y);
}

double GetValue(string text)
{
    System.Console.Write(text);
    return Convert.ToDouble(Console.ReadLine());
}
double k1 = GetValue("k1 = ");
double b1 = GetValue("b1 = ");

double k2 = GetValue("k2 = ");
double b2 = GetValue("b2 = ");

var coordinates = IntersectionPoint(k1, b1, k2, b2);
//System.Console.WriteLine(coordinates.Item1);
//System.Console.WriteLine(coordinates.Item2);
System.Console.WriteLine(coordinates);

