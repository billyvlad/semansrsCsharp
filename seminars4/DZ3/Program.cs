int lenArray = ReadInt("Введите массив: ");

int[] randomArray = new int[lenArray];
for (int i = 0; i < randomArray.Length; i++)
{
    randomArray[i] = new Random().Next(1, 100);
    Console.Write(randomArray[i] + " ");
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}



//int size = new Random().Next(0, 100);
//int[] array = new int[size];

//for (int i = 0; i < array.Length; i++)
//{
//    array[i] = new Random().Next(0, 100);
//}
//Console.WriteLine(size);
//PrintArray(array);

//void PrintArray(int[] array)
//{
//    for (int i = 0; i < array.Length; i++)
//    {
//        Console.Write(array[i] + " ");
//    }
//}
