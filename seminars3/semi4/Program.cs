// Console.Write("Введите число: ");
// double num = int.Parse(Console.ReadLine());

// Math.Pow(int,число) - введение в степень
// Math.Sqrt(int, число) - корень
// Math.Round(число) - математическое округление
// math.Abs(число) - модуль


// Напишите программу, которая по заданному номеру четверти, показывает
// диапазон возможных координат точек в этой четверти (x and y) 


Console.WriteLine("Введите координаты точки 1: " );
string[] sArr = Console.ReadLine().Split(' ');
int num1 = Convert.ToInt32(sArr[0]);
int num2 = Convert.ToInt32(sArr[1]);

Console.WriteLine("Введите координаты точки 2: " );
string[] sArr2 = Console.ReadLine().Split(' ');
int num3 = Convert.ToInt32(sArr2[0]);
int num4 = Convert.ToInt32(sArr2[1]);

double result = Math.Round(Math.Sqrt(Math.Pow((num3 - num1), 2) + Math.Pow((num4 - num2), 2)), 3);
Console.Write(result);
