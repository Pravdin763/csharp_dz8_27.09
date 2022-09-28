// Напишите программу, которая заполнит спирально массив 4 на 4.

int n = 4;
int[,] array = new int[n, n];

int num = 1;

for (int delta = 0; delta < n - 1; delta++)
{
    for (int i = 0 + delta; i < n - delta; i++)
    {
        array[0 + delta, i] = num;
        num++;
    }
    num--;
    for (int i = 0 + delta; i < n - delta; i++)
    {
        array[i, n - 1 - delta] = num;
        num++;
    }
    num--;
    for (int i = n - 1 - delta; i >= 0 + delta; i--)
    {
        array[n - 1 - delta, i] = num;
        num++;
    }
    num--;
    for (int i = n - 1 - delta; i >= 1 + delta; i--)
    {
        array[i, 0 + delta] = num;
        num++;
    }
}



for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write($"{array[i, j],3} ");
    }
    Console.WriteLine();
}