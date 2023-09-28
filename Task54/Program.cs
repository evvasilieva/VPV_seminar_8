/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/


int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}


void BubleSortLines(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}


int[,] Gen2DArrayInt(int row, int column, int range)
{
    int i = 0; int j = 0;
    int[,] arr = new int[row, column];
    while (i < row)
    {
        j = 0;
        while (j < column)
        {
            arr[i, j] = new Random().Next(0, range);
            j++;
        }
        i++;
    }
    return arr;
}


void Print2DArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine("");
    }
}


int row = ReadData("Количество строк матрицы: ");
int column = ReadData("Количество столбцов матрицы: ");
int range = ReadData("Диапазон элементов массива от 0 до ..... ? : ");
int[,] arr2D = Gen2DArrayInt(row, column, range);
Console.WriteLine("Исходный 2D массив: ");
Print2DArr(arr2D);
BubleSortLines(arr2D);
Console.WriteLine();
Console.WriteLine("Отсортированный 2D массив: ");
Print2DArr(arr2D);
