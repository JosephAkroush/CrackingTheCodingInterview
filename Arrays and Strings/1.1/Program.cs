static bool HasUniqueCharacterSet(string input)
{
    bool[] characterSet = new bool[256];

    for (int i = 0; i < input.Length; i++)
    {
        int val = input[i];

        if (characterSet[val])
        {
            return false;
        }

        characterSet[val] = true;
    }

    return true;
}
