Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 2)
{
    int count = 2;
    while (count <= number)
    {
        Console.Write($"{count} ");
        count = count + 2;
    }
}
else
    Console.WriteLine("Не правильно введено число");