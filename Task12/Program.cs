Console.WriteLine("Введите 1 число");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число");
int secondNum = Convert.ToInt32(Console.ReadLine());
int multiple = firstNum % secondNum;
if (multiple == 0) Console.WriteLine($"{firstNum},{secondNum} -> кратно");
else Console.WriteLine($"{firstNum},{secondNum} -> не кратно, остаток {multiple}");