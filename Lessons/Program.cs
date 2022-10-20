//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

/*
Console.WriteLine("Введите первое число");
int number_A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number_B = Convert.ToInt32(Console.ReadLine());
if (number_A > number_B)
    Console.WriteLine($"Число Максимальное {number_A} и Минимальной {number_B}");
else
{
    if (number_B > number_A)
        Console.WriteLine($"Число Максимальное {number_B} и Минимальной {number_A}");
    else
        Console.WriteLine($"Числа {number_A} {number_B} равны");
}
*/

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
/*
Console.WriteLine("Введите первое число");
int number_A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number_B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третие число");
int number_C = Convert.ToInt32(Console.ReadLine());
int imax = 0;
if (number_A > number_B)
{
    if (number_A > number_C)
    {
        imax = number_A;
        Console.WriteLine("Ура это оно");
        Console.WriteLine(imax);
    }
    else
    {
        imax = number_C;
        Console.WriteLine("Ура это оно1");
        Console.WriteLine(imax);
    }   
}
else
{
    if (number_B > number_C)
    {
        imax = number_B;
        Console.WriteLine("Ура это оно");
        Console.WriteLine(imax);
    }
    else
    {
        imax = number_C;
        Console.WriteLine("Ура это оно");
        Console.WriteLine(imax);
    }   
}
*/

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет
/*
Console.WriteLine("укажите число");
int number_A = Convert.ToInt32(Console.ReadLine()); ;
if (number_A % 2 == 0)
{
    Console.WriteLine("Число четное");
}
else
{
    Console.WriteLine("Число нечетное");
}
*/

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
/*
Console.WriteLine("Укажите число");
int A = Convert.ToInt32(Console.ReadLine());
int y = 1;
while (y <= A)
{
    if (y % 2 == 0)
        Console.WriteLine(y);
    y++;
}
*/