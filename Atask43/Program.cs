// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double IntersectionPoint(double b1, double k1, double b2, double k2)
{
    //return Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2) + (z1 - z2) * (z1 - z2));
    return Math.Sqrt(Math.Pow(x1 - x2, 2)
                    + Math.Pow(y1 - y2, 2)
                    + Math.Pow(z1 - z2, 2));
}

double GetValue(string text)
{
    System.Console.Write(text);
    return Convert.ToDouble(Console.ReadLine());
}

double b1 = GetValue("b1 = ");
double k1 = GetValue("k1 = ");
double b2 = GetValue("b1 = ");
double k2 = GetValue("k2 = ");

double point = IntersectionPoint(b1, k1, b2, k2);
System.Console.WriteLine(point);

// int[] CreatePoint2D()
// {
//     return new int[]{1,2,5};
// }
// (int x, int y) CreatePoint2D()
// {
//     return (1, 2);
// }
// var point = CreatePoint2D();
// Console.WriteLine(point.y);