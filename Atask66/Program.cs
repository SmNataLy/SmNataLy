// Задайте значения M и N.
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int GetNumberByUser(string text)
{
    Console.Write(text + " ");
    return Convert.ToInt32(Console.ReadLine());
}
int firstNum = GetNumberByUser("Bведите значение M: ");
int lastNum = GetNumberByUser("Bведите значение N: ");

int ArithmeticProgression(int lastNum)
{
    return (lastNum + firstNum) * (lastNum - firstNum + 1) / 2;
}
int number = ArithmeticProgression(lastNum);
System.Console.WriteLine(number);
