// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write(value: "Введите число А: ");
int numberA = Convert.ToInt32(value: Console.ReadLine());

Console.Write(value: "Введите число В: ");
int numberB = Convert.ToInt32(value: Console.ReadLine());

if (numberA > numberB)
{
    Console.WriteLine("Число А больше чем В");
}
else 
{
    Console.WriteLine("Число В больше чем А");
}