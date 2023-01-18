﻿//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:

int[,] matrix = new int[3, 4] {{1, 4, 7, 2},
                               {5, 9, 2, 3},
                               {8, 4, 2, 4}};


Console.WriteLine("Введите координаты");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
if (m > 3-1 && n > 4-1)
    Console.WriteLine("Такого числа нет");
else
{
    object number = matrix.GetValue(m, n);
    Console.WriteLine(number);
}
