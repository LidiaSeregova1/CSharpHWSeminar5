// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


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
 
int sum = 0;

for (int i = 0; i < arr.Length; i+=2)
    sum = sum + arr[i];

    Console.WriteLine($"всего {arr.Length} чисел, сумма элементов на нечётных позициях = {sum}");

