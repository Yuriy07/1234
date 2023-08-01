// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

void SumFromMToN(int M, int N)
{
    Console.Write(SumMN(M - 1, N));
}


int SumMN(int M, int N)
{
    int summa = M;
    if (M == N)
        return 0;
    else
    {
        M++;
        summa = M + SumMN(M, N);
        return summa;
    }
}

int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int M = GetInfo("Введите меньшее число N: ");
int N = GetInfo("Введите большее число M: ");
SumFromMToN(M, N);


