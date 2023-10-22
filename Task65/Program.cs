Console.WriteLine("Введите  первое натуральное число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите  второе натуральное число: ");
int sekondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber < 1 || sekondNumber < 1)
{
    Console.WriteLine("Некорректный ввод!");
    return;
}

void PrintNaturalNumbers(int firstNum, int sekondNum)
{
    if (firstNum > sekondNum)
    {
       PrintNaturalNumbers(firstNum, sekondNum + 1);
       Console.Write($"{sekondNum} ");
    }else if (firstNum < sekondNum)
    {
        PrintNaturalNumbers(firstNum, sekondNum - 1);
        Console.Write($"{sekondNum} ");
    }
    else Console.Write($"{sekondNum} ");
}

PrintNaturalNumbers(firstNumber, sekondNumber);