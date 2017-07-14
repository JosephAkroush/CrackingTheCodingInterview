static string Reverse(string input)
{
    if (String.IsNullOrEmpty(input))
    {
        return null;
    }

    char[] result = new char[input.Length];

    for (int i = 0; i < input.Length; i++)
    {
        result[i] = input[input.Length - i - 1];
    }

    return new string(result);
}
