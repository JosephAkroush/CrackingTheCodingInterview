static Node Partition(Node head, int x)
{
    Node node = head;
    Node lessHead = null;
    Node lessTail = null;
    Node greaterHead = null;
    Node greaterTail = null;

    while (node != null)
    {
        Node next = node.Next;
        node.Next = null;

        if (node.Data < x)
        {
            if (lessHead == null)
            {
                lessHead = node;
                lessTail = lessHead;
            }
            else
            {
                lessTail.Next = node;
                lessTail = node;
            }
        }
        else if (node.Data > x)
        {
            if (greaterHead == null)
            {
                greaterHead = node;
                greaterTail = greaterHead;
            }
            else
            {
                greaterTail.Next = node;
                greaterTail = node;
            }
        }

        node = next;
    }

    if (lessHead == null)
    {
        return greaterHead;
    }

    lessTail.Next = greaterHead;

    return lessHead;
}
