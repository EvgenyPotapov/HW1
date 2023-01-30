// Задача №2 Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.
Console.WriteLine("Введите число a: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число b: ");
int b = int.Parse(Console.ReadLine()!);
if (b > a)
{
    Console.WriteLine($"{b}");
}
else
    Console.WriteLine($"{a}");