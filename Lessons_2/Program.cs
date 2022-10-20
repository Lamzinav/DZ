//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1

/*
int Second(int b)
{
    b = b % 100;
    b = b / 10;
    return b;
}
int a = new Random().Next(100, 1000);
Console.WriteLine(a);
int z = Second(a);
Console.Write($"second digit {z}");
*/



// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

/*
int a = new Random().Next(100, 1000000);
if (a > 99)
{
    void ThirdDigit(int c)
    {
        c = c / 100;
        c = c % 10;
        Console.WriteLine(a);
        if (c > 0 || c == 0)
            Console.WriteLine($"third digit {c}");
    }
    ThirdDigit(a);
}
else
    Console.WriteLine("no third digit");
*/

//2 - ой вариант задачи 13

/*
Console.Write("Enter the number");
int a = Convert.ToInt32(Console.ReadLine());

if (a > 99)
{
    int ThirdDigit(int a)
    {
        string a1 = Convert.ToString(a);
        Console.WriteLine($"third digit {a1[2]}");
        return a;
    }

    ThirdDigit(a);

}
if (a < -99)
{
    int ThirdDigit2(int a)
    {
        string a1 = Convert.ToString(a);
        string w = Convert.ToString(a1[3]);
        int s = Convert.ToInt32(w);
       // Console.WriteLine($"third digit -{a1[3]}");
        Console.WriteLine($"third digit {-s}");
        return a;
    }

    ThirdDigit2(a);
}

if (a < 99 && a > -99)
    Console.WriteLine("no third digit");
*/





// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

/*
Console.WriteLine("enter the number from 1 to 7");
int a1 = Convert.ToInt32(Console.ReadLine());
if (a1 > 0 && a1 < 8)
{
    int Week(int a1)
    {
        if (a1 == 1)
        {
            Console.WriteLine("Monday - no");
            return a1;
        }
        if (a1 == 2)
        {
            Console.WriteLine("Tuesday - no");
            return a1;
        }
        if (a1 == 3)
        {
            Console.WriteLine("Wednesday - no");
            return a1;
        }
        if (a1 == 4)
        {
            Console.WriteLine("Thursday - no");
            return a1;
        }
        if (a1 == 5)
        {
            Console.WriteLine("Friday - no");
            return a1;
        }
        if (a1 == 6)
        {
            Console.WriteLine("Saturday - yes");
            return a1;
        }
        if (a1 == 7)

            Console.WriteLine("Sunday - yes");
        return a1;
    }
    int q = Week(a1);
}
else
    Console.WriteLine("Missed, let's try again");
*/