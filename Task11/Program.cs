int number = new Random().Next(100, 1000);

int DelSecond (int num)
{
    int firstDigit = num / 100;
    int lastDigit = num % 10;
    return firstDigit * 10 + lastDigit;
}
int delSecond = DelSecond(number);
Console.WriteLine($"{number} -> {delSecond}");