

int GetNumberByUser(string text)
{
    Console.Write(text + " ");
    return Convert.ToInt32(Console.ReadLine());
}

int CountNumbers(int[] collection)
{
  
    int result = 0;
    for (int i = 0; i < collection.Length; i++)
    {
        Console.WriteLine("Введите элемент {0}: ", i + 1);
        int num = Convert.ToInt32(Console.ReadLine());
        if (num > 0)
        {
            result = result + 1;
        }
        
    }
    return result;
}

int size = GetNumberByUser("Введите длинну массива М: ");
int[] array = new int[size];
int result = CountNumbers(array);
Console.WriteLine(result);

