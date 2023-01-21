Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
int current = -1 * number;
while(current <= number)
{
    Console.Write($"{current}, ");
    current++;
}