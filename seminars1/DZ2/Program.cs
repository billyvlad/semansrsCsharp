// Напишите программу, которая паринимает на вход три числа и выдает максимальное из этих чисел.

Console.Write("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int numberC = int.Parse(Console.ReadLine());
int max = 0;
    if(max < numberA)
    max = numberA;
    if(max < numberB)
    max = numberB;
    if(max < numberC)
    max = numberC;

Console.WriteLine("Максимальное из трех чисел " + max);
