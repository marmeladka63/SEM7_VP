

using System;
using static System.Console;
//Console.Clear();

static void Main(string[] args)
        {
            int[,] arr = {{ 1, 2, 3, 4 }, { 5, 6, 7, 8}}; //Массив
            int find = 25; //Искомое число
            int m=0, n=0;
            bool f = false;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (find == arr[i, j]) { m = i;n = j;f = true; };
                    Console.Write("{0}\t", arr[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            if (f)
                Console.WriteLine($"Число найдено. Строка {m+1} Столбец {n+1}");
            else
                Console.WriteLine("Число не найдено");
 
            Console.ReadKey();
        }
