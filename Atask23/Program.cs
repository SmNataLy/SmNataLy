
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.


Console.Write("Ведите число N: ");
int endNum = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= endNum; i++)
{
    Console.WriteLine($" {i} * {i} * {i} = {i * i * i}");

}