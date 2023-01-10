// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
// является ли этот день выходным.

Console.Write ("введите цифру дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());
if (day >= 5)
    Console.WriteLine("выходной день");
else 
    Console.WriteLine("будний день");


