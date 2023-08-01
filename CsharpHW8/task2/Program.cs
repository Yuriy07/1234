// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


void NumberRowMinSumElements(int[,] massive)
{
    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;
    for (int i = 0; i < massive.GetLength(1); i++)
    {
        minRow += massive[0, i];
    }
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++) sumRow += massive[i, j];
        if (sumRow < minRow)
        {
            minRow = sumRow;
            minSumRow = i;
        }
        sumRow = 0;
    }
    Console.Write($"Строка с наименьшей суммой элеменов: {minSumRow + 1}");
}

void PrintDoubleMassive(int[,] massive)
{
    for(int i = 0; i < massive.GetLength(0); i++)
    {
        for( int j = 0; j < massive.GetLength(1); j++)
        {
            Console.Write($"{massive[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] DoDoubleMassive(int rows, int columns, int minValue, int maxValue)
{
    int[,] resualt = new int[rows, columns];
    for(int i = 0; i < rows; i++)
    {
        for( int j = 0; j < columns; j++)
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
int minValue = GetInfo("Введите начало интервала: ");
int maxValue = GetInfo("Введите конец интервала: ");
int[,] massive = DoDoubleMassive(rows, columns, minValue, maxValue);
PrintDoubleMassive(massive);
Console.WriteLine();
NumberRowMinSumElements(massive);