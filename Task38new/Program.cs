int[] CreateArrayRndInt(int size, int min, int max)
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

int MaxNumbers(int[] arr)
{
    int max = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (max < arr[i]) max = arr[i];
    }
    return max;
}

int MinNumbers(int[] arr)
{
    int min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (min > arr[i]) min = arr[i];
    }
    return min;
}

int DefferanceMinMax(int min, int max)
{
    int deferanse = max - min;
    return deferanse;
}

int[] array = CreateArrayRndInt(6, 1, 100);
PrintArray(array);
int min = MinNumbers(array);
int max = MaxNumbers(array);
int result = DefferanceMinMax(min, max);
Console.WriteLine($"min = {min} max = {max}");
Console.WriteLine($"Разница между максимальным и минимальным = {result}");