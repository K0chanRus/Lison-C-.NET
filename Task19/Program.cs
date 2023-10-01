int ReversalNumber (int number)
{
    int fourthNum = (number / 10) % 10;
    int fifthNum = number % 10;
    int reversalNum = ((fifthNum * 10) + fourthNum) * 1000;
    return reversalNum;
}

bool ComparisonNumber (int revNum, int osnNum)
{
    bool resNum = (revNum == osnNum);
    return resNum;
}

Console.WriteLine("Введите пятизначное число :");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 9999 && num < 100000)
{
    int reversalNumber = ReversalNumber(num);
    int osnovNum = num - (num % 1000);
    bool result = ComparisonNumber(reversalNumber, osnovNum);
    Console.WriteLine(result ? "Да" : "Нет");
}
