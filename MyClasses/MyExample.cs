namespace MyClasses;
using System;
public class MyExample

///<Summary>
///Сздание массива от min до max
///</Summary>
    


{
    public static int[,] GetArray(int rows,int columns, int min, int max)
    {
        int[,] result=new int[rows,columns];

        for(int i=0; i<rows; i++)
        {
            for(int j=0;j<columns;j++)
            {
                result[i,j]=new Random().Next(min,max);
            }
        }
        return result;
    }
}
