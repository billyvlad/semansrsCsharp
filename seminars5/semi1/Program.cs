// Задайте массив из 12 элементов,заполенный случайными числами
// из промежутка -9,9. Найдите сумму отрицательных и положительных элементов массива.

int[] arr = new int[12];
int sumPos = 0;
int sumNeg = 0;

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(-9, 10);
    Console.Write($"{arr[i]}, ");
    if (arr[i] < 0) sumNeg += arr[i];
    else sumPos += arr[i];
}
Console.WriteLine("\b\b ");

Console.WriteLine("Сумма положительных чисел в массиве: {0}, ",  sumPos);
Console.WriteLine("Сумма отрицательных чисел в массиве: {0}, ",  sumNeg);