int[] bridge = new int[] { 1, 1, 0, 1, 1 };
int bridgeLength = bridge.Length;

Console.WriteLine(CountWays(bridge, bridgeLength));
Console.ReadLine();

static int CountWays(int[] bridge, int n)
{
    int result = 0;
    for (int i = 0; i < n; i+=2)
    {
        if (i + 1 < n)
            if (bridge[i] == 0 && bridge[i+1] == 0)
                return 0;
        else if(bridge[i] != 0)
                result += 1;
    }

    if(n == 2)
    {
        if (bridge[0] == 0 || bridge[1] == 0)
            return 1;
        
        else
            return 3;
        
    }
    for (int i = 0; i < n; i+=2)
    {
        if (i + 1 < n)
            result += CountTwo(bridge[i], bridge[i + 1]);
        else if(bridge[i] != 0)
            result += 1;
    }

    return result;
}

static int CountTwo(int x, int y)
{
    if (x == 0 || y == 0)
        return 1;
    
    else
        return 2;
}

