// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.

Console.Write("Ведите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

int savedNum = num; //сохраняет заданное целое число
int reverse = 0; //хранит обратную сторону заданного целого числа
while (savedNum > 0)
{
    int r = savedNum % 10;
    reverse = reverse * 10 + r;
    savedNum = savedNum / 10;
}

if (num == reverse)
{
    Console.Write("да");
}
else
{
    Console.Write("нет");
}
    

   
    
