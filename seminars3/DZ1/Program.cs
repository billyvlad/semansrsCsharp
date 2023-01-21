Console.Write("Введите пятизначное число: ");
string  num = Console.ReadLine();
void CheckingNumber(string num)
{
  if (num[0] == num[4] || num[1] == num[3])
  {
    Console.WriteLine($"число: {num} - это число - палиндром");
  }
  else Console.WriteLine($"число: {num} - это число - не палиндром");
}

if (num!.Length == 5)
{
  CheckingNumber(num);
}
else Console.WriteLine($"Введите правильное число");
