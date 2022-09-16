// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Clear();

Console.Write("Введите число ");
int num=Convert.ToInt32(Console.ReadLine());

int count=1;
int div;

while (count<=num)
{
    div=count%2;
    if (div==0)
    {
        Console.Write(count+" ");
    }
    count++;
}