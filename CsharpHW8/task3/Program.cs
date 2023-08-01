// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void ResultMassive(int rows, int columns, int[,] massive, int[,] secondMassive)
{
    int[,] resultMassive = new int[rows, columns];
    if (massive.GetLength(0) != secondMassive.GetLength(1))
    {
        Console.WriteLine("Матрицы нельзя перемножить!");
        return;
    }
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < secondMassive.GetLength(1); j++)
        {
            
            resultMassive[i, j] = 0;
            for (int k = 0; k < massive.GetLength(1); k++)
            {
                resultMassive[i, j] += massive[i, k] * secondMassive[k, j];
            }
        }
    }
    PrintDoubleMassive(resultMassive);
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
int minValue = GetInfo("Введите начало интервала: ");
int maxValue = GetInfo("Введите конец интервала: ");
int[,] massive = DoDoubleMassive(rows, columns, minValue, maxValue);
int[,] secondMassive = DoDoubleMassive(rows, columns, minValue, maxValue);

PrintDoubleMassive(massive);
Console.WriteLine();
PrintDoubleMassive(secondMassive);
Console.WriteLine();
ResultMassive(rows, columns, massive, secondMassive);