void TableCube (int number)
{
    int count = 1;
    while (count <= number)
    {
        Console.WriteLine($"{count,3} {count * count * count,7}");
        count++;
    }
}

Console.WriteLine ("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

TableCube(num);
