// Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.


Random rnd = new Random();
void PrintArray(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}  ");
        }
        Console.WriteLine();
    }
}

void FillArray(double[,] matrix)
{
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Convert.ToDouble(rnd.Next(-20, 70)/10.0);;
        }
    }
}

double[,] matr = new double[3, 4];
FillArray (matr);
PrintArray (matr);
