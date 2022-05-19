//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
/*Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет*/

using System;
using static System.Console;
Console.Clear();


int[,] startArray = GetRandomArray(4, 4, 1, 10);
PrintArray(startArray);
Console.WriteLine();

WriteLine(Value(startArray));





double[,] GetRandomArray(int rows, int columns, int min, int max)
{
    double[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
            result[i, j] = new Random().Next(min, max);
    }
    return result;
}



int Value(int[,] array)
{
    Console.Write("Ввведите номер строки i=");
    int n = int.Parse(Console.ReadLine());
    Console.Write("Введите номер столбца j=");
    int m = int.Parse(Console.ReadLine());
    int t = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (m == i && n == j) Console.Write($"{array[n, m]} ");
            
                else Console.Write("Такого числа нет ");


                }
                
            }return array[n, m];
            
        }
    













    void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j]} ");

            }
            Console.WriteLine();
        }
    }

