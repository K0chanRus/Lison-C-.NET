int ThirdNum(int num)
{
    return num % 10;
}

Console.Write("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100)
    Console.WriteLine("Третьей цыфры нет");
else if (number >= 100 && number <= 999)
{
    int thirdNum = ThirdNum(number);
    Console.WriteLine($"{number} -> {thirdNum}");
}
else
{
    while (number >= 999)
    {
        number = number / 10;
    }
    int thirdNum = ThirdNum(number);
    Console.Write($"-> {thirdNum}");
}