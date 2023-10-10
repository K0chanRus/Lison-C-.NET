bool IsExistTriangle(int a, int b, int c)
{
    return a < b + c && b < b + c && c < a + b;
}

Console.Write("Введите 1 сторону: ");
int side1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2 сторону: ");
int side2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 3 сторону: ");
int side3 = Convert.ToInt32(Console.ReadLine());
bool result = IsExistTriangle(side1, side2, side3);
Console.WriteLine(result ? "Треугольник существует" : "Треугольник не существует");
