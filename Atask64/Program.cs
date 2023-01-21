// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии

int GetNumberByUser(string text)
{
    Console.Write(text + " ");
    return Convert.ToInt32(Console.ReadLine());
}

int firstNum = GetNumberByUser("Bведите значение N: ");
int lastNum = 1;
string NumbersRec(int lastNum, int firstNum)
{
    if (lastNum <= firstNum) return NumbersRec(lastNum + 1, firstNum) + $"{lastNum}, ";
    else return String.Empty;
}
string number = NumbersRec(lastNum, firstNum);
System.Console.WriteLine(number);
