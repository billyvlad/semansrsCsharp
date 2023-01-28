// Напишите программу, которая выводит массив из 8 эллеметов, заполненный нулями и единицами в случайном порядке
int lenArray = ReadInt("Введите массив: ");

int[] randomArray = new int[lenArray];
for (int i = 0; i < randomArray.Length; i++)
{
    randomArray[i] = new Random().Next(0, 2);
    Console.Write(randomArray[i] + " ");
}

int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
