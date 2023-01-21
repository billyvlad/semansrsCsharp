// Нахождение заданного пользователем find числом эллемент массива

int[] array = {35, 222, 333, 666, 223, 4423, 123, 345};

int n = array.Length;
int find = 666;


int index = 0;
while (index < n)
{

    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    // index = index + 1'
    index++;
}