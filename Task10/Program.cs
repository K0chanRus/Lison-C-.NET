int SecondNumber (int num)
{
    int delLast = num % 10;
    int delFirst = num / 100;
    return (num - delLast - (delFirst * 100)) / 10;
}

Console.Write("Введите 3 значное число:");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 100 && number <= 999)
{
int secondNumber = SecondNumber(number);
Console.WriteLine(secondNumber);
}
else
Console.WriteLine("Число указано не правильное");