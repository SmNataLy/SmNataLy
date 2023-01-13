// Напишите программу, которая выводит массив из N элементов,
// заполненный нулями и единицами в случайном порядке.
// Самое левое число != 0
// Данный массив есть двоичное представление десятичного числа
// [1,0,1,1,0,1,0,0]
// Реализовать перевод двоичного числа в десятичное

// 1. Ввод N
// int <- (string)
static int GetNumberByUser(string text)
{
    Console.Write(text + " ");
    return Convert.ToInt32(Console.ReadLine());
}
int size = GetNumberByUser("введите N: ");

// 2. Создание массива
// 
int[] CreateArray(int size)
{
    int[] array = new int[size];
    return array;
}

int[] array = CreateArray(size);

// 3. Заполнение массива 0 и 1
// void <- (int[])


void FillArray(int[] collection)
{
    int length = collection.Length; //длинна массива
    int index = 0;
    
    while (index < length)
    {
        collection[index] = new Random().Next(2);
        index++;
    }
    collection[0] = 1; // Самое левое число != 0
}
// 4. Печать массива
// string <- (int[])

string PrintArray(int[] array)
{
    string output = String.Empty;
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        output=output + $"{array[i]} ";
    }
    return output;
}

// // 5. Конвертация из 2-ого в 10-ое
// // int <- (int[])

// 76543210
// 10110100 = 1*2^7 + 0*2^6 + 1*2^5 + 1*2^4 + 0*2^3 + 1*2^2 + 0*2^1 + 0*2^0

int Conversion(int[] arrayBin)
{
    int count = arrayBin.Length;
    int exponent = arrayBin.Length - 1;
    int result = 0;
    for (int i = 0; i < arrayBin.Length; i++)
    {
        if (arrayBin[i] == 1)
        {
            result += Convert.ToInt32(Math.Pow(2, exponent));
        }
        exponent--;
    }
    return result;
}

// 6. 10110100 >> 180
// string <- (int[] , int)
string GoodPrint(int[] bin, int dec)
{
return $"{String.Join("", bin)} >> {dec}";
}

//int size = GetNumberByUser("введите N");

FillArray(array); //метод - кот-ый заполняет массива
int result = Conversion(array);
string binPrint = PrintArray(array); //метод - кот-ый печатает массива
Console.WriteLine(binPrint);
Console.WriteLine(GoodPrint(array, result));