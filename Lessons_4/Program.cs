// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

/*
Console.WriteLine("Enter number");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter degree");
int b = Convert.ToInt32(Console.ReadLine());
if (b >= 0)
{
    int Metod(int a)
    {
        int f = 1;
        for (int degree = 1; degree <= b; degree++)
            f = f * a;
        int result = f;
        return result;
    }
    int z = Metod(a);
    Console.WriteLine($"number of your degree {z}");
}
else
    Console.WriteLine("Enter a positive power");
*/


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12


/*
void CountNumber(int value)
{
    if (value > 0)
    {
        int result = 0;
        while (value > 0)
        {
            result += value % 10;
            value /= 10;
        }
        Console.WriteLine($"Sum of numbers =  {result}  ");
    }
    if (value < 0)
    {
        int result = 0;
        while (value < 0)
        {
            result += value % 10;
            value /= 10;
        }
        Console.WriteLine($"Sum of numbers =  {result}  ");
    }
}

Console.WriteLine("Enter number");
int value = Convert.ToInt32(Console.ReadLine());
CountNumber(value);
if (value == 0)
    Console.WriteLine($"Sum of numbers =  0  ");
*/

/*
int[] PrintArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Array[{i}] = ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void Perebor(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

Console.WriteLine("Input a numbers of elements");
int n = Convert.ToInt32(Console.ReadLine());

int[] myArray = PrintArray(n);
Perebor(myArray);
*/

// Console.Write("Input a min possible value:  ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value:  ");
// int max = Convert.ToInt32(Console.ReadLine());



