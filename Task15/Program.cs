bool WeekDay (int num)
{
    return num == 6 || num == 7;
}

Console.Write("Введите день недели: ");
int day = Convert.ToInt32(Console.ReadLine());
if (day > 0 && day < 8) {
bool result = WeekDay(day);
Console.WriteLine(result ? "Да" : "Нет");
}
else Console.Write("Нет такого дня недели");