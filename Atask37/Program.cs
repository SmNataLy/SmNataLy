//Найдите произведение пар чисел в одномерном массиве. 

//Парой считаем первый и последний элемент, второй и предпоследний и т.д. 

//Результат запишите в новом массиве.


// 1. Ввод N

int GetNumberByUser(string text)
{
    Console.Write(text + " ");
    return Convert.ToInt32(Console.ReadLine());
}
int size = GetNumberByUser("введите N: ");

// 2. Создание и заполнение массива рандомными числами

int[] array = new int[size];
void FillArray(int[] collection)
{
    int length = collection.Length; //длинна массива
    int index = 0;

    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void ProductPairsNum(int[] array)
{
    int[] result = new int[array.Length / 2];
    for (int i = 0; i < array.Length / 2; i++)
    {
        result[i] = array[i] * array[array.Length - 1 - i];
        Console.Write($"{result[i]} ");
    }
    Console.WriteLine();
}

FillArray(array);
PrintArray(array);
ProductPairsNum(array);


