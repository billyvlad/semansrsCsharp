Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= num; i++)
{
    Console.Write(i * i * i + ", ");
}
Console.WriteLine("\b\b ");




Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int x = 1;
while(x <=num)
{
    Console.Write(Cube(x) + " ");
    x++;
}
int Cube(int x)
{
return x * x * x;
}


// Не до конца понял как можно сделать по другому через Pow