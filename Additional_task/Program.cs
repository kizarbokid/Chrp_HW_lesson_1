// Напишите программу.Какая сумма элементов массива больше – с первого до элемента с номером К или от элемента с номером К+1 до последнего.
//На вход подается массив чисел. Затем вводится переменная K. На выход программа должна вывести или "Первая часть" или "Вторая часть"
//Например, при вводе массива [8 11 15 8 9 10] и числа 3. Программа должна вывести 1 часть, так как 42 больше, чем 19.
Console.Clear();
Console.Write("Input n: "); //Размерность
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input K: "); //Условие
int k = Convert.ToInt32(Console.ReadLine());
int first_sum =0 , second_sum=0;
int [] numbers = new int[n];

for (int i = 0; i < n; i++)
{
    Console.Write($"Input number: {i+1} of {n}: "); 
    numbers[i] = Convert.ToInt32(Console.ReadLine());
    if (i<k)
    {
        first_sum=first_sum + numbers[i];
    }
    else
    {
        second_sum=second_sum + numbers[i];
    }
    
}

if (first_sum>second_sum)
{
    Console.Write($"First part ({first_sum}) is more than the second ({second_sum})");
}
else if (first_sum<second_sum)
{
    Console.Write($"Second part ({second_sum}) is more than the first ({first_sum})");
}
else
{
    Console.Write($"Second part ({second_sum}) is equal to the first ({first_sum})");
}

//for (int i = 0; i < n; i++)
//{
//    Console.Write($"{numbers[i]}; "); 
//}
