//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.  a = 5; b = 7 -> max = 7  a = 2 b = 10 -> max = 10  a = -9 b = -3 -> max = -3

Console.WriteLine("Программа по нахождению максимума и минимума среди двух чисел!");

Console.WriteLine("Введите первое число:");

string? numberString1 = Console.ReadLine();

int number1 = int.Parse(numberString1!);

Console.WriteLine("Введите второе число:");

string? numberString2 = Console.ReadLine();

int number2 = int.Parse(numberString2!);

if (number1 > number2)
    {
        Console.WriteLine("Первое число max");
        Console.WriteLine("Второе число min");
    }

if (number1 < number2)
    {
        Console.WriteLine("Первое число min");
        Console.WriteLine("Второе число max");
    }

if (number1 == number2)
    {
        Console.WriteLine("Ввели одинаковые числа. Попробуйте еще раз.");
    }

