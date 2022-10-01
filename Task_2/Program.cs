// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Input number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input another number: ");
int b = Convert.ToInt32(Console.ReadLine());
    int max;

if (a>b)
{
    max=a;
}
else
{
    max=b;
}

Console.Write("max = ");
Console.WriteLine(max);