// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void WriteIntNumber(int num, int count)
{
    if (count > num) return;
    WriteIntNumber(num, count + 1);
    Console.Write(count + ", ");
}

int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int num = GetInfo("Введите чило N: ");
int count = 1;
WriteIntNumber(num, count);