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

int[] GetSumPozitiveNegativElem(int[] arr)
{
    int sumPozitive = 0;
    int sumNegative = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0) sumPozitive += arr[i];
        else sumNegative += arr[i];
    }
    return new int[] {sumPozitive, sumNegative};
}

int GetSumPozitiveElem(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) sum += arr[i];
    }
    return sum;
}

int GetSumNegativElem(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0) sum += arr[i];
    }
    return sum;
}

int[] array = CreateArrayRndInt (12, -9, 9);
PrintArray(array);
int[] sumPozitiveNegativElem = GetSumPozitiveNegativElem(array);
Console.WriteLine($"Сумма положительных элементов -> {sumPozitiveNegativElem[0]}");
Console.WriteLine($"Сумма негативных элементов -> {sumPozitiveNegativElem[1]}");

int sumPozitive = GetSumPozitiveElem(array);
int sumNegative = GetSumNegativElem(array);
Console.WriteLine($"Сумма положительных элементов -> {sumPozitive}");
Console.WriteLine($"Сумма негативных элементов -> {sumNegative}");
