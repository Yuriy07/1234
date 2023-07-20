// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


double raz(double[] array)
{
    double min = array[0];
    double max = array[0];
    int i = 1;
    while (i < array.Length)
    {
        if (max < array[i])
            max = array[i];
        if (min > array[i])
            min = array[i];
        i++;
    }
    return max - min;
}

double[] MakeNewRandomArray(int size, int beginValue, int endValue)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round(new Random() .NextDouble() * 100, 2);
    }
    return array;
}

double[] array = MakeNewRandomArray(4, -1, 4);
Console.Write("[" + string.Join(", ", array) + "]" + " -> " + raz(array));