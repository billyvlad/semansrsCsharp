// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа

int num = new Random().Next(100 , 1000);
int num1, num2, num3;
Console.WriteLine(num);
num1 = num % 10;
num /= 10;
num2 = num % 10;
num /= 10;
num3 = num % 10;
num /= 10;

Console.WriteLine(num3 + " " + num1);


int number = new Random().Next(100, 1000);      // Решение Леши
int digit1 = number / 100;
int digit3 = number % 10;

int result = digit1 * 10 + digit3;
Console.WriteLine($"{number} -> {result}");