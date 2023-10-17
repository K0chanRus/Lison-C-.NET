double FindXCoord(double k1, double k2, double b1, double b2)
{
    double x = (b1 - b2)/(k2 - k1);
    return x;
}

double FindYCoord(double k1, double b1, double x)
{
    double y = k1 * x + b1;
    return y;
}

Console.Write("Введите число b1 = ");
double numberB1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число k1 = ");
double numberK1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число b2 = ");
double numberB2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число k2 = ");
double numberK2 = Convert.ToDouble(Console.ReadLine());
double xCoord = FindXCoord(numberK1, numberK2, numberB1, numberB2);
double yCoord = FindYCoord(numberK1, numberB1, xCoord);
Console.Write($"Пересечение в точке ({xCoord}:{yCoord})");