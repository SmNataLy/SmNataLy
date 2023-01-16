// 1. Ввод длинны массива М

int GetNumberByUser(string text)
{
    Console.Write(text + " ");
    return Convert.ToInt32(Console.ReadLine());
}

// 2. Создание и заполнение массива числами c клавиатуры

void FillArray(int[] collection)
{
    int index = 0;
    for (int i = 0; i < collection.Length; i++)
    {
        Console.WriteLine("Введите элемент {0}: ", i + 1);
        int num = Convert.ToInt32(Console.ReadLine());
        collection[index++] = num;
    }    
}

// 4. Печать массива

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int size = GetNumberByUser("Введите длинну массива М: ");
int[] array = new int[size];

FillArray(array);
PrintArray(array);









