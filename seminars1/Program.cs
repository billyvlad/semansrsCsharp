// Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное на само себя).

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int result = number * number;

// Вывод в лоб 
Console.Write("Квадрат числа ");
Console.Write(number);
Console.Write(" Равен ");
Console.WriteLine(result);
// Вывод с $
Console.WriteLine($"Квадрат числа {number} равен {result}");
// Вывод с обращением к переменным
Console.WriteLine("Квадрат числа {0} равен {1}", number, result);
// Использование библиотеки Math
int result1 = Convert.ToInt32(Math.Pow(number, 2));
Console.WriteLine("Квадрат числа {0} равен {1}", number, result1);

Console.WriteLine("Квадрат числа " + number + " равен " + result1);