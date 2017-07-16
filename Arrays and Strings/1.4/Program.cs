static void Replace(char[] input, int length)
{
    char[] output = new char[length];
    int i = 0;
    int j = 0;

    while (i < length && j < length)
    {
        if (input[i] == ' ')
        {
            output[j] = '%';
            output[j + 1] = '2';
            output[j + 2] = '0';
            j = j + 3;
        }
        else
        {
            output[j] = input[i];
            j++;
        }

        i++;
    }

    Console.WriteLine(new string(output));
}
