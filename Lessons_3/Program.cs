//Задача 19

//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

/*
Console.WriteLine("Enter the number");
int a = Convert.ToInt32(Console.ReadLine());
int temp = a;
int c;

int palindrome(int x)
{
    x = 0;
while (a > 0)
{
    c = a % 10;
    x = x * 10 + c;
    a = a / 10;
}
if (temp == x)
    Console.WriteLine("It's a palindrome!");
else
    Console.WriteLine("It's not a palindrome!");
    return x;
}
palindrome(a);
*/


// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53


/*
void Main()
{
    Console.Clear();
    Console.WriteLine("Enter х1 :  ");
    double x1 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Enter y1 :  ");
    double y1 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Enter z1 :  ");
    double z1 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Enter х2 :  ");
    double x2 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Enter y2 :  ");
    double y2 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Enter z2 :  ");
    double z2 = Convert.ToDouble(Console.ReadLine());

    double res = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2) + Math.Pow((z1 - z2), 2));
    double c = Math.Round(res, 2);
    Console.WriteLine($"distance between points in 3D space {c}");
}

Main();
*/


// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


Console.WriteLine("Enter the number");
 int x = Convert.ToInt32(Console.ReadLine());
void Kub ()
{
   int i = 1;
while (i <= x )
{
  int y = Convert.ToInt32(Math.Pow(i, 3)); 
  Console.WriteLine(y);
  i++;  
}
}
Kub();
