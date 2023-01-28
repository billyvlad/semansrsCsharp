// Напишите программу, которая принимает на вход число и 
// выдает сумму чисел от 1 до числа.

Console.WriteLine("Введите число: ");
int A = int.Parse(Console.ReadLine());

int sum(int num)
{
    int Count = 0;
    for (int i = 1; i <= num; i++)  // когда задали i = 1, num считает все числа от 1 до num включительно num из за i <= num
    {
        Count += i;
    }
    return Count;
}

Console.WriteLine($"Сумма чисел от 1 до {A} равна {sum(A)}");