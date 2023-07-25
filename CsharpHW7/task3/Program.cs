// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


double[] CalcAvg(int[,] massive)
{
    double[] avgNumbers = new double[massive.GetLength(1)];
    for (int i = 0; i < massive.GetLength(1); i++)
    {
        double result = 0.0;
        for (int j = 0; j < massive.GetLength(0); j++)
        {
            result += massive[j, i];
        }
        avgNumbers[i] = result / massive.GetLength(0);
    }
    return avgNumbers;
}

void PrintDoubleMassive(int[,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            Console.Write($"{massive[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] DoDoubleMassive(int rows, int columns, int minValue, int maxValue)
{
    int[,] resualt = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            resualt[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return resualt;
}

int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int rows = GetInfo("Введите количество строк массива: ");
int columns = GetInfo("Введите количество столбцов массива: ");
int[,] massive = DoDoubleMassive(rows, columns, 0, 9);
PrintDoubleMassive(massive);
double[] avgNumbers = CalcAvg(massive);
Console.Write("Средние значения столбцов: ");
for (int i = 0; i < avgNumbers.Length; i++)
{
Console.Write(avgNumbers[i].ToString("F1") + "; ");
}
