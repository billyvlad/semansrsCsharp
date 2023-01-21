// Напишите программу, которая принимает на вход число N
// и выдает таблицу квадратов чисел от 1 до N

int num = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= num; i++)
{
    Console.Write(i * i + ", ");
}
Console.WriteLine("\b\b ");


Console.WriteLine(String.Join(", ", Enumerable.Range(start: 1, count: num).Select(s => s * s)));