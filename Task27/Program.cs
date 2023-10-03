int SumNumber (int num)
{
    int sumNum = 0;
    while (num > 0)
    {
        sumNum = sumNum + (num % 10);
        num = num / 10;
    }
    return sumNum;
}

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

int sunNumber = SumNumber(number);
Console.WriteLine(sunNumber);