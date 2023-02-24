// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел

Console.WriteLine("Введите число 1: ");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число 2: ");
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число 3: ");
int num3 = int.Parse(Console.ReadLine());

int max;
if (num1 > num2)
{
    max = num1;
}
else
{
    max = num2;
}

if (num3 > max)
{
    max = num3;
}

Console.WriteLine($"{num1}, {num2}, {num3} -> {max}");
