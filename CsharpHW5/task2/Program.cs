// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int SumNumOddIndex(int[] array)
{
    int SumNumOddIndex = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        SumNumOddIndex += array[i];
    }
    return SumNumOddIndex;
}

int[] MakeNewRandomArray(int size, int beginValue, int endValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(beginValue, endValue);
    }
    return array;
}

int[] array = MakeNewRandomArray(6, -2, 8);
Console.WriteLine("[" + string.Join(", ", array) + "]" + " -> " + SumNumOddIndex(array));
