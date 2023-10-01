double FindDistanse (int xa, int ya, int za, int xb, int yb, int zb)
{
    int cathet1 = xa - xb;
    int cathet2 = ya - yb;
    int cathet3 = za - zb;
    double distanse = Math.Sqrt((cathet1 * cathet1)+(cathet2 * cathet2)+(cathet3 * cathet3));
    return distanse;
}

Console.WriteLine("Введите координаты точки A:");
Console.Write("Х: ");
int xACoordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yACoordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int zACoordinate = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B:");
Console.Write("Х: ");
int xBCoordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yBCoordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int zBCoordinate = Convert.ToInt32(Console.ReadLine());

double result = FindDistanse(xACoordinate, yACoordinate, zACoordinate, xBCoordinate, yBCoordinate, zBCoordinate);
double resultRound = Math.Round(result, 2, MidpointRounding.ToZero);
Console.WriteLine(resultRound);