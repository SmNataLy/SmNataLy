// На входе получаем массив на выходе создаем новый массив, который заполняется числами кратными 5:

// метод создания массива

// метод заполнения массива

// метод подсчета чисел кратных 5

// решение задачи

// метод печати

int[] array = {2, 5, 6, 10, 32, 30 };

int count = 0;
int index = 0; // объявить переменную

while(index < array.Length)
{
    if (array[index] % 5 == 0)
    {
        count++;
    }
    index++;
}

int[] arrayNew = new int [count];
index = 0; // присвоить значение
int indexNew = 0;

while (index < array.Length)
{
    if (array[index] % 5 == 0)
    {
        arrayNew[indexNew] = array[index];
        indexNew++;
    }
    index++;
}
Console.WriteLine(arrayNew);
index = 0;
while (index < arrayNew.Length)
{
    System.Console.WriteLine(arrayNew[index]);
    index++;
}
