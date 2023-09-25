bool IsOneSqeare(int num1, int num2)
{
    return num1 * num1 == num2 || num2 * num2 == num1;
}

Console.Write("Введите 1 число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2 число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

bool result = IsOneSqeare(number1, number2);
Console.WriteLine(result ? "Да" : "Нет");