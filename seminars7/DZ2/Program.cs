//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

//Например, задан массив:

//1 4 7 2
//5 9 2 3
//8 4 2 4
//1 7 -> такого числа в массиве нет
//1 1 -> 9




int[,] CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++) 
    {
            for (int j = 0; j < array.GetLength(1); j++) 
            {
                array[i, j] = new Random().Next(1, 10);                                                                                       
            }
     }
    return array;   
}



void PrintArray(int[,] array) // вывод на экран

{
        for (int i = 0; i < array.GetLength(0); i++)
        {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                        Console.Write($"|   {array[i, j]}  ");                  
                }
                System.Console.WriteLine();
        }
}


void CheckNumber(int[,] array)
{
    Console.WriteLine();
    Console.Write("Введите строку: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите столбец: ");
    int column = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число для проверки: ");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    if (array[rows - 1, column - 1] == number)
    {
        Console.WriteLine($"{number} - такое число по вашему запросу есть");
    }
    else
    {
        Console.WriteLine($"{number} - такого числа по вашему запросу нет");
    }
}

int lines = 3;
int numbers = 4;

int[,] array = new int[lines, numbers];
CreateArray(array);
PrintArray(array);
CheckNumber(array);