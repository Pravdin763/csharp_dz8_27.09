//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] first = new int[3, 3];
int[,] second = new int[3, 3];
int[,] third = new int[3, 3];
Random rand = new Random();

int[,] FirstArray(int[,] arr1)
{
    Console.WriteLine("Первая матрица");

    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            arr1[i, j] = rand.Next(1, 10);
            Console.Write(arr1[i, j] + "  ");
        }
        Console.WriteLine();
    }
    return arr1;
}

int[,] SecondArray(int[,] arr2)
{
    Console.WriteLine("Вторая матрица");
    for (int z = 0; z < 3; z++)
    {
        for (int x = 0; x < 3; x++)
        {
            arr2[z, x] = rand.Next(1, 10);
            Console.Write(arr2[z, x] + "  ");
        }
        Console.WriteLine();
    }
    return arr2;
}

int[,] ThirdArray(int[,] arr1, int[,] arr2, int[,] arr3)
{
    Console.WriteLine("Перемножение матриц");

    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            for (int k = 0; k < arr2.GetLength(0); k++)
            {
                arr3[i, j] += arr1[i, k] * arr2[k, j];
            }
        }
    }
    return arr3;
}

void PrintThirdMatrix(int[,] matr3)
{
    for (int i = 0; i < matr3.GetLength(0); i++)
    {
        for (int j = 0; j < matr3.GetLength(1); j++)
        {
            Console.Write($"{matr3[i, j]}   ");
        }
        Console.WriteLine();
    }
}

FirstArray(first);
SecondArray(second);
PrintThirdMatrix(ThirdArray(first, second, third));