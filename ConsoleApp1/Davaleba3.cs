//3
Console.WriteLine(isProperly("()))"));
static bool isProperly(string text)
{
    char[] chars = { '(',')' };
    if (text.Length % 2 == 1)
    {
        return false;
    }
    else
    {
        char[] charArray = text.ToCharArray();
        for (int i = 0; i < text.Length; i++)
        {
            if(charArray[i] == chars[0])
            {
                for (int j = 0; j < text.Length; j++)
                {
                    if(charArray[j] == chars[1])
                    {// თუ ვიპოვე მეწყვილე ვცვლი მნიშვნელობას რომ აღარ ვეძებო იგივე
                        charArray[i] = '*';
                        charArray[j] = '*';
                        break;
                    }
                }
            }
            else if(charArray[i] == chars[1])//თუ დაიწყო ეგრევე ) ამით ან დარჩა ეგ ეგრევე False
            {
                return false;
            }
        }
        return true;
    }
}