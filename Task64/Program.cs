Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 1)
{
    Console.WriteLine("Некорректный ввод!");
    return;
}

void PrintNaturalNumbers(int num)
{
    if(num == 0) return;
    Console.Write($"{num} ");
    PrintNaturalNumbers(num - 1);
}

PrintNaturalNumbers(number);