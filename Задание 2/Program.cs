//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите число 1 ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2 ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 3 ");
int c = Convert.ToInt32(Console.ReadLine());

int max = (a);

if (max<b)
{
    max = (b);
}
else
{
   max = (a);
}

if (max<c)
{
    max = (c);
}
else
{
   max = (b);
}
Console.Write("max = ");
Console.WriteLine(max);