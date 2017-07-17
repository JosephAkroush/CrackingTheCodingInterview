
static void RemoveDuplicatesWithBuffer(Node head)
{
    if (head == null)
    {
        return;
    }

    List<int> buffer = new List<int>();
    Node node = head;

    while (node != null)
    {
        if (buffer.Contains(node.Next.Data))
        {
            node.Next = node.Next.Next;
        }
        else
        {
            buffer.Add(node.Next.Data);
        }

        node = node.Next;
    }
}

static void RemoveDuplicatesWithoutBuffer(Node head)
{
    if (head == null)
    {
        return;
    }

    Node node = head;

    while (node != null)
    {
        Node runner = node;

        while (runner.Next != null)
        {
            if (node.Data == runner.Next.Data)
            {
                runner.Next = runner.Next.Next;
            }
            else
            {
                runner = runner.Next;
            }
        }

        node = node.Next;
    }
}
