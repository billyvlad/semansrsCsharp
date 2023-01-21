Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string numbers = Convert.ToString(number);
if (numbers.Length > 2)
{
  Console.WriteLine("третья цифра - " + numbers[2]);
}
else 
{
  Console.WriteLine("третьей цифры нет");
}


int result = -1;
if (number >= 100)
{
    while(number > 999)
    {
      number = number / 10;
    }
result = number % 10;
Console.WriteLine("Третья цифра - " + result);
}
else
{
  Console.WriteLine("третьей цифры нет");
}



