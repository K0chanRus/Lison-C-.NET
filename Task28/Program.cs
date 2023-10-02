int Factorial (int num)
{
    int res = 1;
    for (int i = 1; i <= num; i++)
    {
        checked
        {
            res = res * i;
        }
    }
    return res;
}

Console.WriteLine("Введите цлое положительное число :");
int number = Convert.ToInt32(Console.ReadLine());

int factorial = Factorial(number);
Console.WriteLine($"произведение чисел от 1 до {number} = {factorial}");