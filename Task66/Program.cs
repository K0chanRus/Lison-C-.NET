int PrintSumNaturalNumbers(int m, int n)
{
    if (m == n)
    {
        return n;
    }
    if (m > n)
    {
        return n + PrintSumNaturalNumbers(m, n + 1);
    }else if (m < n)
    {
        return n + PrintSumNaturalNumbers(m, n - 1);
    }else{
        return 1;
    }
}



Console.Write("Введите  первое натуральное число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите  второе натуральное число: ");
int sekondNumber = Convert.ToInt32(Console.ReadLine());
if (firstNumber < 1 || sekondNumber < 1)
{
    Console.WriteLine("Некорректный ввод!");
    return;
}
Console.WriteLine(PrintSumNaturalNumbers(firstNumber, sekondNumber));