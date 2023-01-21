// Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.

Console.Write("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine());
    if(numberA > numberB) 
    { 
        Console.WriteLine("Число большее " + numberA);
        Console.WriteLine("Число меньшее " + numberB);
    }
    if(numberA < numberB)
    {
        Console.WriteLine("Число большее " + numberB);
        Console.WriteLine("Число меньшее " + numberA);
    }



