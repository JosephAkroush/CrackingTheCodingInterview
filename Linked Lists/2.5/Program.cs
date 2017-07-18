static void SumReverse(Node headA, Node headB)
{
    string operandA = GetOperandRecursively(headA, headA.Data.ToString());
    string operandB = GetOperandRecursively(headB, headB.Data.ToString());

    int a = int.Parse(operandA);
    int b = int.Parse(operandB);

    Console.WriteLine($"{a} + {b} = {a + b}");
}

static string GetOperandRecursively(Node head, string operand)
{
    if (head == null)
    {
        return operand;
    }

    if (head.Next == null)
    {
        return head.Data.ToString();
    }

    operand = operand.Insert(operand.Length - 1, GetOperandRecursively(head.Next, head.Next.Data.ToString()));

    return operand;
}

static void SumForward(Node headA, Node headB)
{
    Node nodeA = headA;
    Node nodeB = headB;

    string operandA = "0";
    string operandB = "0";

    while (nodeA != null)
    {
        operandA += nodeA.Data;

        nodeA = nodeA.Next;
    }

    while (nodeB != null)
    {
        operandB += nodeB.Data;

        nodeB = nodeB.Next;
    }

    int a = int.Parse(operandA);
    int b = int.Parse(operandB);

    Console.WriteLine($"{a} + {b} = {a + b}");
}
