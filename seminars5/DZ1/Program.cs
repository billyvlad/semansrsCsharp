// Задача 34: 
//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
//которая покажет количество чётных чисел в массиве.


int[] numbers = new int[6];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
int count = 0;
for (int i = 0; i < numbers.Length; i++)
    if (numbers[i] % 2 == 0)
    count++;
    Console.WriteLine($"Количество чётных чисел в массиве - {count}");

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        numbers[i] = new Random().Next(100,1000);
}
void PrintArray(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++) 
        Console.Write(numbers[i] + " ");
             Console.WriteLine();
}
