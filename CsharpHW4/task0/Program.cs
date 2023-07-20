// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

bool Validate(int numberB)
{
    if(numberB < 0)
    {
        Console.WriteLine("Показатель степени не должен быть меньше нуля");
        return false;
    }
    return true;
}

int ToDegree(int numberA, int numberB)
{
    int result = 1;
    for (int i = 1; i <= numberB; i++)
    {
        result = result * numberA;
    }
    return result;
}

int ReadInt(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int numberA = ReadInt("Введите число A: ");
int numberB = ReadInt("Введите степень B: ");
ToDegree(numberA, numberB);

if (Validate(numberB))
{
    Console.WriteLine($"Число {numberA} в степени {numberB} равно {ToDegree(numberA, numberB)}");
}