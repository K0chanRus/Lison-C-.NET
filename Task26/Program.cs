int CounutDigit(int number)
{
    if (number == 0) return 1;
    int count = 0;
    while (number != 0)
    {
        number = number / 10;
        count++;
    }
    return count;
}

Console.WriteLine("Введите число :");
int num = Convert.ToInt32(Console.ReadLine());

int result = CounutDigit(num);
Console.WriteLine($"Количество цыфр в числе: {result}");