//mod 14 mod 5 = 4
//div 14 div 5 = 2

//int a = number / 10;
//int b = number / 10 % 10;
//int c = number / 100;
//int d = number % 100;

//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Ведите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int secondDigit = number / 10 % 10;

Console.WriteLine(secondDigit);