//Находим индекс заданного числа:

int[] array = {1, 12, 31, 4, 15, 16, 31, 17, 18};

int n = array.Length;
int find = 31;

int index = 0;

while (index < n)
{ 
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index ++;
}
//     
//int[] array = new int[3];
//void FillArray(int[] collection);
//{
    //int length = collection.length;
    //int index = 0;
    //while (index < length)
    //{
       // collection[index] = newRandom().Next(1,10);
       // index ++;
   // }
//}
// void PrintArray(int[]col)