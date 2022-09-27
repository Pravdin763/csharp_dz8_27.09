// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.


Console.WriteLine("Введите колличество строк ");
int row = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите колличество столбцов ");
int col = int.Parse(Console.ReadLine()!);
int[,] array = new int[row, col];


void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(20);
        }
    }
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j],3} ");
        }
        Console.WriteLine();
    }
}


int[] Average(int[,] matr, int row1)
{
    int[] arr = new int[row1];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        int count = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            count += matr[i, j];
        }
        arr[i] = count;
    }
    return arr;
}

void PrinMintSumRow(int[] array)
{
    int min = 100;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    Console.WriteLine($"Сумма минимальной строки {min}");
    for (int i = 0; i < array.Length; i++)
    {
        if (min == array[i])
        {
            Console.WriteLine($"Строка с минимальной суммой элеменотов: {i + 1}");
        }
    }
}

FillArray(array);
PrintArray(array);
PrinMintSumRow(Average(array, row));