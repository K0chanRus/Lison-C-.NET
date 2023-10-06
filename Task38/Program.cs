double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i]=rnd.NextDouble() * (max - min) + min;
    }
    return arr;
}

void PrintArrayDouble(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]:F1}, ");
        else Console.Write($"{arr[i]:F1}");
    }
}

double MaxNumbers(double[] arr)
{
    double max = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (max < arr[i]) max = arr[i];
    }
    return max;
}

double MinNumbers(double[] arr)
{
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (min > arr[i]) min = arr[i];
    }
    return min;
}

double DefferanceMinMax(double min, double max)
{
    double deferanse = max - min;
    return deferanse;
}

double[] array = CreateArrayRndDouble(6, 1, 100);
PrintArrayDouble(array);
double min = MinNumbers(array);
double max = MaxNumbers(array);
double result = DefferanceMinMax(min, max);
Console.WriteLine($"min = {min:F1} max = {max:F1}");
Console.WriteLine($"Разница между максимальным и минимальным = {result:F1}");