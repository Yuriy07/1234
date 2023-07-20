// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] MakeNewRandomArray(int size,int beginValue, int endValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random() .Next(beginValue, endValue);
    }
    return array;
}

int[] array = MakeNewRandomArray(8,  1, 9);
Console.WriteLine("[" + string.Join(", ", array) + "]");