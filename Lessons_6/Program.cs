
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

/*
Console.Write("how many numbers would you like to enter ");
int s = Convert.ToInt32(Console.ReadLine());
void PositiveNumbers(int number)
{
    int q = 0;
    number = 0;
    for (int i = 1; i <= s; i++)
    {
        Console.Write($"{i} = ");
        q = Convert.ToInt32(Console.ReadLine());
        if (q > 0)
            number++;
    }
    Console.Write($"numbers greater than 0 : {number}");
}

PositiveNumbers(s);
*/

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.Write("Enter the first number ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the second number ");
double z2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the third number ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the fourth number ");
double x2 = Convert.ToDouble(Console.ReadLine());
void IntersectionPoint(double k1, double k2, double b1, double b2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    if (k1 - k2 == b1 - b2)
        Console.Write("lines are parallel ");
    else
    {
        x = Math.Round(x, 1);
        y = Math.Round(y, 1);
        Console.Write($"({x}; {y})");
    }
}
IntersectionPoint(z1, z2, x1, x2);
