// Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
Console.WriteLine("Давайте сравним 2 числа.");
Console.WriteLine("Введите число a:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b:");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    Console.WriteLine($"Число a = {a}; b = {b} -> max = {a} ");
}
else if (b > a)
{
    Console.WriteLine($"Число a = {a}; b = {b} -> max = {b} ");
}
else Console.WriteLine($" Числа a = {a} и b = {b} равны");