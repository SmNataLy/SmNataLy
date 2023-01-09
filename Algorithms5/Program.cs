// ####  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
int number = 34628;

if (number < 100)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    while (number >= 100)
    {
        number = number % 100;
        Console.WriteLine(number);
    }    
}
Console.WriteLine(number % 100);
