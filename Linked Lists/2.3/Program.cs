static void Delete(Node node)
{
    if (node == null || node.Next == null)
    {
        return;
    }

    node.Data = node.Next.Data;
    node.Next = node.Next.Next;
}
