// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

void Sumnum(int num, int len)
{
    int sum = 0;
    for(int i = 1; i <= len; i++)
    {
        sum = sum + num % 10;
        num = num / 10;
    }
    Console.WriteLine($"Сумма цифр равен {sum}.");
}

int NumLen(int num)
{
    int i = 0;
    while(num > 0)
    {
        num /= 10;
        i++;
    }
    return i;
}

int ReadInt(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int num = ReadInt("Введите число: ");
int len = NumLen(num);
Sumnum(num, len);