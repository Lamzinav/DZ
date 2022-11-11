//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2


int[] PrintArray(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
        Console.WriteLine(array[i] = new Random().Next(100, 1000));
    return array;
}

int number = 0;
void EvenNumber(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0)
            number++;
    Console.Write($"There are even numbers in the {number} array");
}
Console.Write("Input a numbers of elements  ");
int s = Convert.ToInt32(Console.ReadLine());

int[] myarray = PrintArray(s);
EvenNumber(myarray);




// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


/* 
int[] PrintArray(int size)
{
   int[] array = new int[size];

   for (int i = 0; i < size; i++)
       Console.WriteLine(array[i] = new Random().Next(1, 100));
   return array;
}

int index = 0;
void OddElement(int[] array)
{
for (int i = 0; i < array.Length; i++)
   {
       if (i % 2 == 1)
          index = index + array[i];   
   }
   Console.WriteLine($"Sum of elements of odd indices = {index}");
}     


Console.Write("Input a numbers of elements  ");
int s = Convert.ToInt32(Console.ReadLine());

int[] myarray = PrintArray(s);
OddElement(myarray);
*/


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


/*
double[] PrintArray(int size)
{
    double[] array = new double[size];

    for (int i = 0; i < size; i++)
    {
        Console.Write("array[{0}] = ", i);
        array[i] = Convert.ToDouble(Console.ReadLine());
    }
    return array;
}

double MaxElement(double[] array, double max)
{
    for (int i = 0; i < array.Length; i++)
        if (array[i] > max)
            max = array[i];
    return max;
}

double MinElement(double[] array, double min)
{
    for (int i = 0; i < array.Length; i++)
        if (array[i] < min)
            min = array[i];
    return min;

}

Console.Write("Input a numbers of elements  ");
int s = Convert.ToInt32(Console.ReadLine());
double[] myarray = PrintArray(s);
double max = myarray[0];
double min = myarray[0];
double Max = MaxElement(myarray, max);
double Min = MinElement(myarray, min);
double z = Max - Min;
z = Math.Round(z, 1);
Console.WriteLine($"Difference between maximum and minimum elements of array = {z}");
*/
