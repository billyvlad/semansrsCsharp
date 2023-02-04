// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве

int[] array = new int[5];
FillArray(array);
Console.Write("Введите число поиска: ");
int number = Convert.ToInt32(Console.ReadLine());

if(array.Contains(number)) Console.Write("Да");
else Console.Write("Нет");

void FillArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
        Console.Write(array[i] + " ");
    }
Console.Write("] -> ");
}