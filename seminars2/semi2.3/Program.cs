// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.

Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if(numberA % numberB == 0 )
{
    Console.WriteLine(numberA + ", " + numberB + " - второе число Кратно первому, остаток " + numberA % numberB); // + - если хочешь добавить два коментария
    
}   
    else
    {   
        Console.WriteLine(numberA + ", " + numberB + " -второе число не Кратно первому, остаток " + numberA % numberB );
        
    }




    

