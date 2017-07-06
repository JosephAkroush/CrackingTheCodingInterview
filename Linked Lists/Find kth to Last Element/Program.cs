public class Node
{
    public int Data { get; set; }
    public Node Next { get; set; }
}

static int FindKthToLastElement(Node head, int k)
{
    if (head == null)
    {
        return 0;
    }

    int i = FindKthToLastElement(head.Next, k) + 1;

    Console.WriteLine("k: {0}, i: {1}", k, i);

    if (i == k)
    {
        Console.WriteLine(head.Data);
    }

    return i;
}
