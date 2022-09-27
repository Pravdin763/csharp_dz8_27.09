//  Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.WriteLine("Введите колличество строк ");
int row = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите колличество столбцов ");
int col = int.Parse(Console.ReadLine()!);
int[,] array = new int[row, col];

int[,] Filling(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(10);
        }

    }
    return arr;
}

void PrintReverseArray()
{
    int[] temp = new int[col];

    for (int i = 0; i < col; i++)
    {
        for (int j = 0; j < col; j++)
            temp[j] = array[i, j];
        Array.Sort(temp);
        Array.Reverse(temp);
        for (int k = 0; k < col; k++)
        {
            array[i, k] = temp[k];
            Console.Write($"{array[i, k]}  ");
        }
        Console.WriteLine();
    }
}

Filling(array);
PrintReverseArray();