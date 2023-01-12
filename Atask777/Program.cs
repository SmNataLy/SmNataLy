// Напишите программу, которая выводит массив из N элементов,
// заполненный нулями и единицами в случайном порядке.
// Самое левое число != 0
// Данный массив есть двоичное представление десятичного числа
// [1,0,1,1,0,1,0,0]
// Реализовать перевод двоичного числа в десятичное


//1. Ввод N
//int <- (string)
static int GetNumberByUser(string text)
{
    Console.Write(text + ": ");
    return Convert.ToInt32(Console.ReadLine());
}
int size = GetNumberByUser("введите N");

// 2. Создание массива


void FillArray(int[] collection)
{
    int length = collection.Length; //длинна массива
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(0, 2);
        index++;
    }
}


void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int[] array = new int[size];

FillArray(array); //метод - кот-ый заполняет массива

PrintArray(array); //метод - кот-ый печатает массива

// void FillArray(int[] collection)
// {
//     int length = size; //длинна массива
//     int index = 0;
//     while (index < length)
//     {
//         collection[index] = new Random().Next(1, 10);
//         index++;
//     }
// }
// Console.WriteLine(collection[index]);


// int[] array = new int[10];
// 2. Создание массива
// int[] <- (int)


// static void Main()
// {
//     int n = 0, a = 0, b = 0;
//     int[] arr = null;

//     Console.Write("Введите n - размер массива arr (n > 1): ");
//     n = Int32.Parse(Console.ReadLine());
//     while (n < 2)
//     {
//         Console.WriteLine("Ошибка: значение n должно быть больше 1!");
//         Console.Write("Повторите ввод: ");
//         n = Int32.Parse(Console.ReadLine());
//     }

//     Console.Write("Введите a - левую границу промежутка для заполнения нулями (a < n): ");
//     a = Int32.Parse(Console.ReadLine());
//     while (a <= 0 || a >= n)
//     {
//         Console.WriteLine("Ошибка: значение a должно быть больше 0 и меньше n!");
//         Console.Write("Повторите ввод: ");
//         a = Int32.Parse(Console.ReadLine());
//     }

//     Console.Write($"Введите b - правую границу промежутка для заполнения нулями (b > a и b <= n): ");
//     b = Int32.Parse(Console.ReadLine());
//     while (b <= a || b > n)
//     {
//         Console.WriteLine($"Ошибка: значение b должно быть больше a и меньше или равно n!");
//         Console.Write("Повторите ввод: ");
//         b = Int32.Parse(Console.ReadLine());
//     }

//     arr = new int[n];
//     Console.Write("Полученный массив arr: ");
//     for (int i = 0; i < arr.Length; i++)
//         arr[i] = Convert.ToInt32(!((i + 1 > a) && (i + 1 < b)));
//     Console.WriteLine(String.Join(", ", arr));

//     Console.ReadKey(true);
// }
