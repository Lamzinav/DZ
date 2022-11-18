//Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами
// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9


/*
double[,] GetArray(int m, int n, int minValue, int maxValue)
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().NextDouble() + new Random().Next(minValue, maxValue + 1);
            result[i, j] = Math.Round(result[i, j], 1);
            //Console.Write($"{result[i,j]}  " );
        }
        //  Console.WriteLine();
    }
    return result;
}

void PrintArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}  ");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Enter the number of rows in the array: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number of array columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the minimum value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the maximum value: ");
int max = Convert.ToInt32(Console.ReadLine());

double[,] array = GetArray(rows, columns, min, max);

PrintArray(array);
*/

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1 7 -> числа с такими индексами в массиве нет



/*
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }

    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

// bool ArrayElement(int[,] inArray)
// {
//   Console.WriteLine("Введите координаты");
//     int a = Convert.ToInt32(Console.ReadLine());
//     int b = Convert.ToInt32(Console.ReadLine());
//     if (a > inArray.GetLength(0) || b > inArray.GetLength(1))
//         return false;
//         else
//            return true ;
// }

void PrintArra(int[,] inArray)
{
    Console.WriteLine("Enter coordinates");
    int a = Convert.ToInt32(Console.ReadLine());
    int b = Convert.ToInt32(Console.ReadLine());
    if (a > inArray.GetLength(0) || b > inArray.GetLength(1))
        Console.WriteLine("there is no such number");
    else
    {
        object c = inArray.GetValue(a, b);
        Console.WriteLine($"Your number = {c}");
    }
}
Console.Clear();
Console.Write("Enter the number of rows in the array: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number of array columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the minimum value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the maximum value: ");
int max = Convert.ToInt32(Console.ReadLine());
int[,] array = GetArray(rows, columns, min, max);
PrintArray(array);
PrintArra(array);
// bool x = ArrayElement(array);
// Console.WriteLine(x);      
*/


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Console.Clear();


int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] result)
{
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            Console.Write($"{result[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
double[] ArithmeticMean(int[,] result, int n)
{
    double[] box = new double[n];
    for (int j = 0; j < result.GetLength(1); j++)
    {
        double z = 0;
        double sum = 0;
        int k = 0;
        for (int i = 0; i < result.GetLength(0); i++)
        {
            sum += result[i, j];
            k++;
        }
        z = sum / k;
        box[j] = Math.Round(z, 1);
        // Console.WriteLine($"Arethmetic value {j + 1} of column {e[j]}  ");
    }
    return box;
}

void PrintArithmetic(double[] box)
{
    Console.Write("Arithmetic mean of each column: ");
    for (int i = 0; i < box.Length; i++)
        Console.Write($"{box[i]} ");

}

Console.Write("Enter the number of rows in the array: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number of array columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the minimum value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the maximum value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] array = GetArray(rows, columns, min, max);
double[] Myarray = ArithmeticMean(array, columns);
PrintArray(array);
PrintArithmetic(Myarray);