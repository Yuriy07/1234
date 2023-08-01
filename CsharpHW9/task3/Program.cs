// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа M и N.
// M = 2, N = 3 -> A(M,N) = 9
// M = 3, N = 2 -> A(M,N) = 29

void AkkermanFunction(int M, int N)
{
    Console.Write(Akkerman(M, N));
}

int Akkerman(int M, int N)
{
    if (M == 0)
    {
        return N + 1;
    }
    else if (N == 0 && M > 0)
    {
        return Akkerman(M - 1, 1);
    }
    else
    {
        return(Akkerman(M - 1, Akkerman(M, N - 1)));
    }
}

int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int M = GetInfo("Введите меньшее число N: ");
int N = GetInfo("Введите большее число M: ");
AkkermanFunction(M, N);