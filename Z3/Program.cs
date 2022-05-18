using MyClasses;
using System;
Console.Clear();
int n=int.Parse(Console.ReadLine());
int m=int.Parse(Console.ReadLine());
int[,] array=MyExample.GetArray(n,m,0,100);

for (int i=0; i<n; i++)
{
    
for (int j=0; j<m; j++)
{
        Console.Write($"{array[i,j]} ");

}
    Console.WriteLine();
}


