int Multiple (int num)
{
    int firstResult = num % 7;
    int secondResult = num % 23;
    return firstResult + secondResult;
}

Console.Write("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

int numResult = Multiple(number);
if (numResult > 0) Console.WriteLine("Нет");
else Console.WriteLine("Да");