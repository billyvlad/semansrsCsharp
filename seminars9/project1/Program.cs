//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
//Выполнить с помощью рекурсии.

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

void count (int number)
{
    if (number < 0) Console.Write($"{number} не натуральное число");
    if (number == 0) return;
    Console.WriteLine("{0,4}", number);
    count (number - 1);
}

count(number);