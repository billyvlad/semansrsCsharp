// напишите программу, которая принимает на вход координаты, причем х не равен 0 и y не равен 0 и выдает номер четверти плоскости, 
// в которой находится эта точка
Console.Write("Введите x: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите y: ");
int y = int.Parse(Console.ReadLine());

if(x > 0 && y > 0) Console.WriteLine("1");
else if (x < 0 && y > 0) Console.WriteLine("2");
else if (x < 0 && y < 0) Console.WriteLine("3");
else if(x > 0 && y < 0) Console.WriteLine("4");
else
{
    Console.WriteLine("Ошибка ввода");
}