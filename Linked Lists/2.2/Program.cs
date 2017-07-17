static int FindKthToLastElement(Node head, int k)
{
    if (head == null)
    {
        return 0;
    }

    int i = FindKthToLastElement(head.Next, k) + 1;

    if (i == k)
    {
        Console.WriteLine(head.Data);
    }

    return i;
}
