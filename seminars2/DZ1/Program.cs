Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int dig2 = number % 100 / 10;
int result = dig2;
Console.WriteLine($"{number} -> {result}");





int dig3 = number % 100 / 10;
int result1 = dig3;

if(number > 1000)
{
    Console.WriteLine("Ты задал больше, чем трехзначное число");
}
else if(number < 100)
{
    Console.WriteLine("ты задал менее трех чисел");

}
else
{
    Console.WriteLine($"{number} -> {result}");
}

