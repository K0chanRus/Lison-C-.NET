int[] CreateArrayRndThird(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
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

int NumEvenNumbersTheArray(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) sum++;
    }
    return sum;
}

int[] array = CreateArrayRndThird(4, 100, 999);
PrintArray(array);
int sumEven = NumEvenNumbersTheArray(array);
Console.WriteLine($"Количество четных чисел в массиве = {sumEven}");