
Console.WriteLine(SumOfDigits(19,19));
Console.Read();

static int SumOfDigits(int x, int y)
{
    if (x > y) {
        int temp = x;
        x = y;
        y = temp;
    }
    int difference = (y - x) + 1, result = 0;
    if (x == y)
    {
        return SumOneDigit(x);
    }
    for (int i = 0; i < difference; i++)
    {
        result += SumOneDigit(x+i);
    }

    return result;
}

static int SumOneDigit(int x)
{
    int result = 0;
    for (int i = 0; i < x.ToString().Length+1; i++)
    {
        result += x % 10;
        x /= 10;
    }
    return result;
}