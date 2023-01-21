// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] matrix = new int[4, 4] {{1, 4, 7, 2},
                                {5, 9, 2, 3},
                                {8, 4, 2, 4},
                                {5, 2, 6, 7}};

int sum = 0;
int index = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    int variable = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        variable = variable + matrix[i, j];
    }
    if (i == 0)
    {
        sum = variable;
        index = i;
    }
    else if (variable < sum)
    {
        sum = variable;
        index = i;
    }
}
Console.WriteLine($"Cуммa элементов строки {index + 1} = {sum}");

