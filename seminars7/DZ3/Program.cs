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



void PrintArray(int[,] array) 

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
void Average(int[,] array)
{
    Console.WriteLine("_________________________");
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum += array[j, i];
        }
        double average = sum / array.GetLength(0);
        Console.Write($" {average:f1} | ");
    }
}

int lines = 3;
int numbers = 4;

int[,] array = new int[lines, numbers];
CreateArray(array);
PrintArray(array);
Average(array);

// Как вы могли заметить - делалось по сути одним принципом и это пока все, что я понял из введения в двумерные массивы)
// Еще понял что можно в целом все через void, но я решил не бацать сюда, а просто отдельно в самостоятельном разборе порешать
// Когда будет след дз - гляньте пожалуйста на самостоятельные разборы, если будет время(я поставлю галочку)

 //Console.Write("Введите кол-во строк "); 
 //m = Int32.Parse(Console.ReadLine()); 
 //Console.Write("Введите кол-во столбцов "); 
 //n = Int32.Parse(Console.ReadLine()); 

 // Можно и ввести так, что б пользователь сам выбирал где и куда, просто где GetLength(0 или 1) сделать еще +1, но это скучно пока что