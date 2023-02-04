int[] array = new int[6];
  for (int i = 0; i < array.Length; i++ )
  {
    array[i] = new Random().Next(1, 100);
    Console.Write(array[i] + " ");
  }

int maxNumber = array[0];
int minNumber = array[0];

  for (int i = 1; i < array.Length; i++)
  {
    if (maxNumber < array[i])
    {
        maxNumber = array[i];
    }
        if (minNumber > array[i])
    {
      minNumber = array[i];
    }
  }

int diff = maxNumber - minNumber;

Console.WriteLine($"Разница между между максимальным ({maxNumber}) и минимальным({minNumber}) элементами: {diff}");