// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)

Console.Write("Введите число: ");
int userNum = int.Parse(Console.ReadLine());

if (userNum % 2 == 0)
{
    Console.WriteLine($"{userNum} -> Да, четное");
}
else
{
    Console.WriteLine($"{userNum} -> Нет, не четное");
}
