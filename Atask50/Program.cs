//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:

int[,] matrix = new int[3, 4] {{1, 4, 7, 2},
                               {5, 9, 2, 3},
                               {8, 4, 2, 4}};


Console.WriteLine("Введите позиции элемента: ");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

if (m < matrix.GetLength(0) && n < matrix.GetLength(1))
{
    int number = matrix[m, n];
    Console.WriteLine(number);
}
else
    Console.WriteLine("Такого числа нет");
