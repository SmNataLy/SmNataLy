// Создай новый массив, который заполняется рандомными числами: 

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

int IndexOf(int[] collection, int find) // метод - который находит нужный элемент в массиве
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];

FillArray(array); //метод - кот-ый заполняет массива
array[4] = 6; // заполняем самостоятельно
array[6] = 6;
PrintArray(array); //метод - кот-ый печатает массива
Console.WriteLine(); //проверка что не яв-ся частью вывода массива

int pos = IndexOf(array, 6);
Console.WriteLine(pos);

// void метод - ничего не возвращает

