int[] InputArray(int num)
{
    int[] array = new int[num];
    int number = 1;
    for (int i = 0; i < num; i++)
    {
        
        Console.Write($"Введите {number} число :");
        array[i] = Convert.ToInt32(Console.ReadLine());
        number++;
    }
    return array;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

int SumIntOutput(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) sum++;
    }
    return sum;
}

Console.Write("Сколько чисел вы хотите ввести:");
int number = Convert.ToInt32(Console.ReadLine());
int[] inputArray = InputArray(number);
PrintArray(inputArray);
int sum = SumIntOutput(inputArray);
Console.WriteLine($"Число положительных элементов = {sum}");