﻿Console.WriteLine("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение массива: ");
int minArr = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение массива: ");
int maxArr = Convert.ToInt32(Console.ReadLine());

int[] GetArr(int n)
{   
    int[] arr = new int[n];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minArr, maxArr + 1);
    }
    return arr;
}

void PrintArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

void ReversArray(int[] arr)
{
    for (int i = arr.Length - 1; i >= 0; i--)
    {
        Console.Write($"{arr[i]} ");
    }
}

int[] array = GetArr(n);
PrintArr(array);
ReversArray(array);