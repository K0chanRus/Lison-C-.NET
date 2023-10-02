int Degree(int num1, int num2)
{
    int number = 1;
    for (int i = 0; i < num2; i++)
    {
        number *= num1;
    }
    return number;
}

Console.WriteLine("Введите число А:");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B:");
int numB = Convert.ToInt32(Console.ReadLine());

if (numB > 0)
{
int degree = Degree(numA, numB);
Console.WriteLine($"{numA}, {numB} -> {degree}");
}
else Console.WriteLine("Степень должна быть натуральной");