// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Write("Input first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Input third number: ");
int c = Convert.ToInt32(Console.ReadLine());
int max=c;
    
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