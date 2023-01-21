
Console.Write("Введите координату X первой точки: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату X второй точки: ");
int xb = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату Y первой точки: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y второй точки: ");
int yb = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату Z первой точки: ");
int ca = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z второй точки: ");
int cb = Convert.ToInt32(Console.ReadLine());

    double p = Math.Sqrt((xa - xb) * (xa - xb) + (ya - yb) * (ya - yb) + (ca - cb) * (ca - cb));
    Console.WriteLine($"Расстояние между точками A и В: {p}");
Console.WriteLine ($"Расстояние между точками A и В = {Math.Sqrt (Math.Pow (xa - xb, 2) +  Math.Pow(ya - yb, 2) + Math.Pow(ca - cb, 2))}");