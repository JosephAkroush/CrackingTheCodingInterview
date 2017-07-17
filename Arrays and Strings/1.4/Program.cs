static void Replace(char[] input, int length)
{
    int spaces = 0;
    int newLength = 0;

    for (int i = 0; i < length; i++)
    {
        if (input[i] == ' ')
        {
            spaces++;
        }
    }

    newLength = length + spaces * 2;

    for (int i = length - 1; i >= 0; i--)
    {
        if (input[i] == ' ')
        {
            input[newLength - 1] = '0';
            input[newLength - 2] = '2';
            input[newLength - 3] = '%';

            newLength = newLength - 3;
        }
        else
        {
            input[newLength - 1] = input[i];

            newLength--;
        }
    }

    Console.WriteLine(new string(input));
}
