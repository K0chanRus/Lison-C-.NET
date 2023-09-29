string GetCoordinateRange (int num)
{
    if(num == 1) return "x > 0, y > 0";
    if(num == 2) return "x < 0, y > 0";
    if(num == 3) return "x < 0, y < 0";
    if(num == 4) return "x > 0, y < 0";
    return null;
}

Console.WriteLine("Ведите номер четверти:");
int quater = Convert.ToInt32(Console.ReadLine());

string getCoordinateRange = GetCoordinateRange(quater);

string result = getCoordinateRange != null
        ? $"Заданому номеру четверти соответствует диапазон {getCoordinateRange}" 
        : $"Введены не коректные данные";
Console.WriteLine(result);