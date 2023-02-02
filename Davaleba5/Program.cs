using System.Numerics;

Console.WriteLine(Zeros(490));

static double Zeros(int number)
{
    BigInteger numberFactorial = 1;
    int result = 0;
    for (int i = 1; i < number+1; i++)
    {
        numberFactorial *= i;
    }
    string numberText = numberFactorial.ToString();

    for (int i = numberText.Length-1; i > 0; i--)
    {
        if(numberText[i] == '0')
        {
            result++;
        }
        else
        {
            break;
        }
    }

    return result;
}