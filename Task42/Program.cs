int ConvertTenInTwo(int number, int inNum)
{
    int result = 0;
    int mult = 1;
    while (number > 0)
    {
        result += number % inNum * mult;
        number /= inNum;
        mult *= 10;
    }
    return result;
}

Console.WriteLine("Введите дясятичное число :");
int num = Convert.ToInt32(Console.ReadLine());
int inTwo = ConvertTenInTwo(num, 2);
Console.WriteLine($"{num} -> {inTwo}");

