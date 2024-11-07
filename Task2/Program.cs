static bool IsGoodBinaryStr(string str)
{
    int countOne = 0;
    int countZero = 0;

    if (str.Length % 2 != 0)
    {
        return false;
    }

    foreach (char ch in str)
    {
        if (ch == '1')
            countOne++;

        else if (ch == '0')
            countZero++;

        else
            return false;

        if (countZero > countOne)
            return false;
    }

    return countOne == countZero;
}

static void Test()
{
    string[] cases = ["111000", "10010", "101"];

    foreach (string str in cases)
    {
        Console.WriteLine($"{IsGoodBinaryStr(str)}");
    }
}

Test();