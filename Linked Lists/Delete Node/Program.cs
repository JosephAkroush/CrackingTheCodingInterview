public class Node
{
    public int Data { get; set; }
    public Node Next { get; set; }
}

static void DeleteNode(Node node)
{
    if (node == null || node.Next == null)
    {
        return;
    }

    node.Data = node.Next.Data;
    node.Next = node.Next.Next;
}
