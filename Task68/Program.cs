int PrintAkkerman(int n, int m)
{
    if (n == 0) return m + 1;
    else if (m == 0) return PrintAkkerman(n - 1, 1);
    else return PrintAkkerman(n - 1, PrintAkkerman(n, m - 1));
}

Console.Write("Введите первое натуральное число: ");
int nNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе натуральное число: ");
int mNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(PrintAkkerman(nNumber, mNumber));