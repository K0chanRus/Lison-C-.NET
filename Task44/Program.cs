int[] FiboArray(int num)
{
    int[] fibonacci = new int[num];
    fibonacci[0] = 0;
    fibonacci[1] = 1;
    for (int i = 2; i < fibonacci.Length; i++)
    {
        fibonacci[i] = fibonacci[i-1] + fibonacci[i-2];
    }
    return fibonacci;
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

Console.WriteLine("Введите число цыфр фибоначи");
int number = Convert.ToInt32(Console.ReadLine());
int[] result = FiboArray(number);
PrintArray(result);