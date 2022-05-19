//  Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
using System;


Console.Clear();
int n=int.Parse(Console.ReadLine());
int m=int.Parse(Console.ReadLine());

double[,] array=GetArray(n,m,-100,100);


for (int i=0; i<n; i++)
{
    
for (int j=0; j<m; j++)
{
        Console.Write($"{array[i,j]} ");

}
    Console.WriteLine();
}




double[,] GetArray(int rows,int columns, int min, int max)
    {
        double[,] result=new double[rows,columns];

        for(int i=0; i<rows; i++)
        {
            for(int j=0;j<columns;j++)
            {
                result[i,j]=new Random().Next(min,max);
            }
        }
        return result;
    }
