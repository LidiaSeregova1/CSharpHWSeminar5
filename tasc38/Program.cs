// Задача 38: Задайте массив натуральных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


int[] GetRandomArrey(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    Random rand = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i]= rand.Next (leftRange, rightRange + 1);
    }
    return array;
}

const int SIZE = 6;
const int LEFTRANGE = 1;
const int RIGHTRANGE = 50;

int [] arr = GetRandomArrey(SIZE, LEFTRANGE, RIGHTRANGE);
Console.WriteLine(string.Join(", ", arr));

int max = 0;
int min = 100;
for (int i = 0; i < arr.Length; i++)
{
    if (arr [i] > max)
        {
            max = arr [i];
        }
    if (arr [i] < min)
    {
        min = arr[i];
    }
        
}

Console.WriteLine($"всего {arr.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");