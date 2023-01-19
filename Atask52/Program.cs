//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:

int[,] matrix = new int[3, 4] {{1, 4, 7, 2},
                                {5, 9, 2, 3},
                                {8, 4, 2, 4}};

for (int j = 0; j < matrix.GetLength(1); j++)
{
    float result = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        result += matrix[i, j];
    }
    Console.WriteLine($"Cреднее арифметическое элементов столбца {j + 1} = {result / matrix.GetLength(0)}");
}


