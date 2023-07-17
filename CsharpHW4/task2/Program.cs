// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


int[] randomArray = new int[8];

for (int i = 0; i < 8; i++)
{
randomArray[i] = new Random().Next(1,9);
Console.Write(randomArray[i] + ", ");
}

// РЕШЕНИЕ: где количество элементов массива равен числу N

// int lenArray = ReadInt("Введите длинну массива: ");

// int[] randomArray = new int[lenArray];
// for (int i = 0; i < randomArray.Length; i++)
// {
//     randomArray[i] = new Random().Next(1,9);
//     Console.Write(randomArray[i] + ", ");
// }


// // Функция ввода
// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }