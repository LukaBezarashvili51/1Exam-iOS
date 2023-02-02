Console.WriteLine(MinSplit(172));
Console.Read();

static double MinSplit(int amount)
{
    int[] coins = new int[] { 1, 5, 10, 20, 50 };
    int[] result = new int[2];

    int i = coins.Length-1;
    result[0] = amount;
    while (amount > 0 && amount != 0)
    {
        if (coins[i] > amount)
        {
            i--;
            continue;
        }
        int[] returned = Split(result[0], coins[i]);
        result[0] = returned[0];
        result[1] = result[1] + returned[1];
        i--;
        amount = result[0];
    }
    return result[1];
}

static int[] Split(int amount, int coin)
{
    int[] array = new int[2];

    array[0] = amount % coin;
    array[1] = amount / coin;

    return array;
}
