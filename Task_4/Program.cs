// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int a = 9,
    b = 1,
    c = 8,
    max=c;
    
if (a>c)
{
    max=a;
}
else if (b>c)
{
    max=b;
}

Console.Write("max = ");
Console.WriteLine(max);