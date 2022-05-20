//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
/*Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет*/




using System;
using static System.Console;
Console.Clear();

int[,] arr = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
Console.Write("Ввведите номер строки i=");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите номер столбца j=");
int m = int.Parse(Console.ReadLine());
int num=0;
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        if (i == n && j == m)
        {
            num= arr[n, m];
              
            }

    }
    
}
if (n>=3^m>=3) Console.Write("Такого числа нет");
else Console.Write(num);





