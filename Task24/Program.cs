int SumNumbers (int num)
{
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
        checked
        {
            sum += i;
        }
    }
    return sum;
}

Console.WriteLine("Введите цлое положительное число :");
int number = Convert.ToInt32(Console.ReadLine());

int sumNumbers = SumNumbers(number);
Console.WriteLine($"сумма от 1 до {number} = {sumNumbers}");