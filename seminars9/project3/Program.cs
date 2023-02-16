//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.


Console.WriteLine("Введите M:");
int M = int.Parse(Console.ReadLine());

Console.WriteLine("Введите N:");
int N = int.Parse(Console.ReadLine());

int Ack (int M, int N)
{
    if (M == 0) return N + 1;
    if (M != 0 && N == 0) return Ack(M - 1, 1);
    if (M > 0 && N > 0) return Ack(M - 1, Ack(M, N - 1));
return Ack(M, N);
}

Console.WriteLine($"Функция Аккермана ({M},{N}) = {Ack(M, N)}");