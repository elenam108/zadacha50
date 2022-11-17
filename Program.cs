// Напишите программу, которая на вход принимает значение элемента в двумерном 
// массиве, и возвращает позицию этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int m = ReadInt("Введите индекс числа строки: ");
int n = ReadInt("Введите индекс числа столбца: ");
int[,] numbers = new int[4, 4];
FillArray2D(numbers);
PrintArray2D(numbers);

if (m < numbers.GetLength(0) && n < numbers.GetLength(1)) Console.WriteLine(numbers[m, n]);
else Console.WriteLine($"Значения с индексом {m} и {n} -> такого числа в массиве нет");

void FillArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

