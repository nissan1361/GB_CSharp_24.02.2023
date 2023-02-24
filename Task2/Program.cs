//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число: ");
string firstUserInput = Console.ReadLine();

Console.WriteLine("Введите второе число: ");
string secondUserInput = Console.ReadLine();

int firstNum = int.Parse(firstUserInput);
int secondNum = int.Parse(secondUserInput);
int max;

if (firstNum > secondNum)
{
    max = firstNum;
    Console.WriteLine($"a= {firstNum}; b= {secondNum} -> max = {max} ");
}
else if (secondNum > firstNum)
{
    max = secondNum;
    Console.WriteLine($"a = {firstNum}; b= {secondNum} -> max = {max}");
}
else
{
    Console.WriteLine($"a = {firstNum}; b = {secondNum} -> a == b");
}
