//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

//m = 3, n = 4.

//0,5 7 -2 -0,2

//1 -3,3 8 -9,9

//8 7,8 -7,1 9







double [,] CreateArray(int rows, int columns)
{
        double [,] array = new double[rows, columns];
        Random num = new Random();
        for (int i = 0; i < array.GetLength(0); i++) 
        {
                for (int j = 0; j < array.GetLength(1); j++) 
                {
                        array[i, j] = Convert.ToDouble(new Random().Next(-50, 50)) / 10;           //array[i, j] = num.Next(-9, 10)+ num.NextDouble();(Но тогда выводится множество после запятой, 
                                                                                                    //не додумался КУДА сюда втулить Math Round) 
                }
        }
        return array; // вернули двумерный массив   
}
//  Да, я не люблю функции, уже 4 раз пересматриваю и без подсказок тяжело пока что, не понимаю:D 
//  но цифровой бог направляет меня, так что справимся))


void PrintArray(double[,] array) // вывод на экран

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

double[,] array = CreateArray(3, 4); 
PrintArray(array); 