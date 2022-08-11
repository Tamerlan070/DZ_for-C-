// Задание 4 Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисе
Console.Write(value: "Введите число А: ");
int numberA = Convert.ToInt32(value: Console.ReadLine());

Console.Write(value: "Введите число В: ");
int numberB = Convert.ToInt32(value: Console.ReadLine());

Console.Write(value: "Введите число C: ");
int numberC = Convert.ToInt32(value: Console.ReadLine());

int max = numberA;

if (numberA > max) max = numberA;
if (numberB > max) max = numberB;
if (numberC > max) max = numberC;

Console.WriteLine ($"Максимальное число = {max}");