Console.Write("Введите первое число: ");
double numberA = double.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
double numberB = double.Parse(Console.ReadLine());
int result1 = Convert.ToInt32(Math.Pow(numberB, 2));
if (numberA == result1)
Console.Write("Первое число является квадратом второго");
else
Console.Write("Первое число не является квадратом второго");