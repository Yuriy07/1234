// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


void SearchNum(int[,] massive)
{   
    bool found = false;
    string positions = "";
    int find = GetInfo("Введите число для поиска: ");
    for(int i = 0; i < massive.GetLength(0); i++)
    {
        for( int j = 0; j < massive.GetLength(1); j++)
        {
            if(find == massive[i, j])
            {
                if (positions != "")
                {
                    positions += ", ";
                }
                positions += $"({i},{j})";
                found = true;
            }
        }
    }
    if(found)
    {
        Console.WriteLine($"{find} -> хранится в точках: {positions}");
    }
    else
    {
        Console.WriteLine($"{find} -> такого числа нет в массиве!");
    }
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
int[,] massive = DoDoubleMassive(rows, columns, 0, 9);
PrintDoubleMassive(massive);
SearchNum(massive);