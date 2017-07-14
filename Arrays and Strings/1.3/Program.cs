static bool AreAnagrams(string a, string b)
{
    // If one string is null but the other isn't, they're not anagrams.
    if (a == null && b != null ||
       a != null && b == null ||
       a == null && b == null)
    {
        return false;
    }

    // If both strings don't match in length, they're not anagrams.
    if (a.Length != b.Length)
    {
        return false;
    }

    int[] ascii = new int[256];

    foreach (char c in a)
    {
        ascii[c]++;
    }

    foreach (char c in b)
    {
        ascii[c]--;

        if (ascii[c] < 0)
        {
            return false;
        }
    }

    return true;
}
