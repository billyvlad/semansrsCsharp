// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник 
// со сторонами такой длины

Console.WriteLine("Введите первое число: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int b1 = Convert.ToInt32(Console.ReadLine());

//if(k1 < k2 + b1 && k2 < b1 + k1 && b1 < k2 + k1) Console.WriteLine("Треугольник может существовать");
//else Console.WriteLine("Треугольник существовать не может");


bool TriangleCheck(int k1, int k2, int b1)
{
    if(k1 < k2 + b1 && k2 < b1 + k1 && b1 < k2 + k1) return true;
    else return false;
}
if(TriangleCheck(k1, k2, b1)) Console.WriteLine("Треугольник может существовать");
else Console.WriteLine("Треугольник существовать не может");

