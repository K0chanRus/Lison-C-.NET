int[] CreateArrayRandom(int size, int min, int max)
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
    Console.Write("]");
}

int GetSumEvenArray(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        sum = sum + arr[i];
        i++;
    }
    return sum;
}

int[] array = CreateArrayRandom(4, -100, 100);
PrintArray(array);
int sumEven = GetSumEvenArray(array);
Console.WriteLine($"Сумма четных чисел = {sumEven}");