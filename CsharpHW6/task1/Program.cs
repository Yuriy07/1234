// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


void Main(string[] args)
{   
    Console.Write("Введите количество чисел: ");
    int M = int.Parse(Console.ReadLine());
    int count = CountPositiveNumbers(M);
    Console.WriteLine("Количество положительных чисел: " + count);
}

int CountPositiveNumbers(int M)
{
    int count = 0;

    for (int i = 0; i < M; i++)
    {
        Console.Write("Введите число " + i + ": ");
        double number = double.Parse(Console.ReadLine());
        if (number > 0)
        {
            count++;
        }
    }
    return count;
}
Main(args);
