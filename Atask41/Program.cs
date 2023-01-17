// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

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

int CountNumbers(int[] arraySource)
{
    int result = 0;
    for (int i = 0; i < arraySource.Length; i++)
    {
        if (arraySource[i] > 0)
        {
            result = result + 1;
        }
    }
    return result;
}

int size = GetNumberByUser("Введите длинну массива М: ");
int[] array = new int[size];
FillArray(array);
int result = CountNumbers(array);
Console.WriteLine(result);

// Код скорректирован с учетом поправок от преподавателя:
// Тут можно было в одном цикле и получать числа от пользователя и считать положительные числа.
// Даже можно было их не записывать в массив, в условиях же этого не требовалось:)

// int GetNumberByUser(string text)
// {
//     Console.Write(text + " ");
//     return Convert.ToInt32(Console.ReadLine());
// }

// int CountNumbers(int[] collection)
// {
  
//     int result = 0;
//     for (int i = 0; i < collection.Length; i++)
//     {
//         Console.WriteLine("Введите элемент {0}: ", i + 1);
//         int num = Convert.ToInt32(Console.ReadLine());
//         if (num > 0)
//         {
//             result = result + 1;
//         }
        
//     }
//     return result;
// }

// int size = GetNumberByUser("Введите длинну массива М: ");
// int[] array = new int[size];
// int result = CountNumbers(array);
// Console.WriteLine(result);
