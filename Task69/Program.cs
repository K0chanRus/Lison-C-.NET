int NumberInStepen(int a, int b)
{
    if (b == 0) return 1;
    return a * NumberInStepen(a, b - 1);
}

Console.WriteLine("Введите число:");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень:");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.Write(NumberInStepen(numberA, numberB));