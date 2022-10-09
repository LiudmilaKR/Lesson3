/*
Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
(можно решить через строку, а можно математически)

14212 -> нет
12821 -> да
23432 -> да
*/
/* Вариант 1 - математическое решение

Console.WriteLine ("Введите любое пятизначное число: ");
int number = int.Parse (Console.ReadLine()!);

if (number < 10000 || number > 99999)
{
    Console.WriteLine ($"Число {number} не является пятизначным!");
}
else
{
    int num1 = number / 10000;
    int num2 = number / 1000 % 10;
    int num3 = number % 1000 / 100;
    int num4 = number % 100 / 10;
    int num5 = number % 10;

    if (num1 == num5 && num2 == num4)
    {
        Console.WriteLine ($"Число {number} - полиндром!");
    }
    else
    {
        Console.WriteLine ($"Число {number} не является полиндромом!");
    }
}
*/
/* Вариант 2 - решение через строки

Console.WriteLine ("Введите любое пятизначное число: ");
string number = Console.ReadLine()!;

if (number.Length == 5)
{
    int num1 = Convert.ToInt32 (number[0]);
    int num2 = Convert.ToInt32 (number[1]);
    int num4 = Convert.ToInt32 (number[3]);
    int num5 = Convert.ToInt32 (number[4]);

    if (num1 == num5 && num2 == num4)
    {
        Console.WriteLine ($"Число {number} - полиндром!");
    }
    else
    {
        Console.WriteLine ($"Число {number} не является полиндромом!");
    }
}
else
{
    Console.WriteLine ($"Число {number} не является пятизначным!");
}
*/

/*
Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
AB = ((xb-xa) в квадрате + (yb-ya) в квадрате + (zb-za) в квадрате) из этого - корень
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine ("Введите координату x первой точки: ");
int xa = int.Parse(Console.ReadLine()!);
Console.WriteLine ("Введите координату y первой точки: ");
int ya = int.Parse(Console.ReadLine()!);
Console.WriteLine ("Введите координату z первой точки: ");
int za = int.Parse(Console.ReadLine()!);
Console.WriteLine ("Введите координату x второй точки: ");
int xb = int.Parse(Console.ReadLine()!);
Console.WriteLine ("Введите координату y второй точки: ");
int yb = int.Parse(Console.ReadLine()!);
Console.WriteLine ("Введите координату z второй точки: ");
int zb = int.Parse(Console.ReadLine()!);

double result = Math.Sqrt (Math.Pow ((xb - xa), 2) + Math.Pow ((yb - ya), 2) + Math.Pow ((zb - za), 2));

Console.WriteLine($"{result:f3}");
*/
/*
Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

Console.WriteLine ("Введите число N большеe 1: ");
int N = int.Parse(Console.ReadLine()!);

int M = 1;

if (N < 1) 
{
    Console.Write ("Вы ввели некорректное число N");
}
else
{
    while (M < N)
    {
        Console.Write ($"{Math.Pow(M, 3)}, ");
        M = M + 1;
    }
    Console.Write ($"{Math.Pow(M, 3)} ");
}