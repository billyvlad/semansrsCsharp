void FillArray(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(1, 10);
        // index = index + 1;
        index++;
    }
}

void PrintArray(int[] collection1)
{
    int count = collection1.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(collection1[position]);
        position++;
    }
}



int[] array = new int[10];

FillArray(array);
PrintArray(array);