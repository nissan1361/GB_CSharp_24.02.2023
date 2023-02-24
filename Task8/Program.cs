// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N

Console.WriteLine("Введите число N: ");
int n = int.Parse(Console.ReadLine());

Console.Write(n + " -> ");

// Воспользуюсь циклом for, так как я умею его использовать:
for (int i = 1; i <= n; i++)
{
    if (i % 2 == 0)
    {
        Console.Write(i + " ");
    }
}
Console.WriteLine("");
