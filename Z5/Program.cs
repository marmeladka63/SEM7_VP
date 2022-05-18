// Создать двумерный массив n строк, m столбцов
// Каждый элемент массива находтся по формуле n+m

using System;

Console.Clear();

int rows = int.Parse(Console.ReadLine());
int colums = int.Parse(Console.ReadLine());
int[,] array = GetArray(rows, colums);

for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
        


int[,] GetArray(int n, int m)
{
    int[,] result = new int[n, m];

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            result[i, j] = i + j;
        }
    }
    return result;
}