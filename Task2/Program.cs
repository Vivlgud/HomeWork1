﻿// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Clear();

Console.Write("Введите число А=");
int numA=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B=");
int numB=Convert.ToInt32(Console.ReadLine());

if (numA==numB)
{
    Console.Write("Числа А и B равны");
}
else if (numA>numB)
{
Console.Write("Число А="+numA+" больше числа B="+numB);
}
else
{
Console.Write("Число B="+numB+" больше числа A="+numA);
}