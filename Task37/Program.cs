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

int[] CountMultipliedPairs(int[] arr)
{
    // int size = 0;
    // if (arr.Length % 2 == 0) size =arr.Length / 2;
    // else size = arr.Length / 2 + 1;
    // Тоже самое что и строка ниже.
    int size = arr.Length / 2 + arr.Length % 2;
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = arr[i] * arr[arr.Length - i - 1];
    }
    if (arr.Length % 2 != 0) result[size - 1] = arr[arr.Length / 2];
    return result;
}

int[] array = CreateArrayRndInt (5, 1, 9);
PrintArray(array);

int[] newArray = CountMultipliedPairs(array);
PrintArray(newArray);