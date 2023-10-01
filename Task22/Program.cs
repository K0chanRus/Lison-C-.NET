void TableSqare (int number)
{
    int count = 1;
    while (count <= number)
    {
        Console.WriteLine($"{count, 3}  {count * count,5}");
        count++;
    }
}



// int Sqare (int number)
// {
//     int n = number * number;
//     return n;
// }

Console.WriteLine ("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
//int tab = 1;
TableSqare(num);
// while (num >= tab)
// {
//     int sqare = Sqare (tab);
//     Console.WriteLine($"{tab} {sqare}");
//     tab++;
// }
