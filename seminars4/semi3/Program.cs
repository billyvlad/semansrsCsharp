// Напишите программу, которая принимает на вход число и выдает произведение от 1 до числа
Console.WriteLine("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());

int MultiPly(int num)
{
    int start = 1;
    for (int i = 1; i <= num; i++)  
    {
        start = i * (start);
    }
    return start;
}

Console.WriteLine($"Произведение чисел от 1 до {A} равна {MultiPly(A)}");