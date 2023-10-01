double FindDistanse (int ax, int ay, int bx, int by)
{
    int catet1 = ax-bx;
    int catet2 = ay-by;
    double distanse = Math.Sqrt((catet1 * catet1) + (catet2 * catet2));
    return distanse;
}

Console.WriteLine("Введите координаты точки A:");
Console.Write("Х: ");
int xCoordinateFirst = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yCoordinateFirst = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B:");
Console.Write("Х: ");
int xCoordinateSecond = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yCoordinateSecond = Convert.ToInt32(Console.ReadLine());

double result = FindDistanse (xCoordinateFirst, yCoordinateFirst, xCoordinateSecond, yCoordinateSecond);
double resultRound = Math.Round(result, 2, MidpointRounding.ToZero);
Console.WriteLine(resultRound);