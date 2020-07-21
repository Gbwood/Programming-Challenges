
//iterate with recursion
static void printLinkedList(SinglyLinkedListNode head)
{
    Console.WriteLine(head.data);
    if (head.next != null)
    {
        printLinkedList(head.next);
    }

}


//add at end
static SinglyLinkedListNode insertNodeAtTail(SinglyLinkedListNode head, int data)
{
    SinglyLinkedListNode runner = head;

    while (runner.next != null)
    {
        runner = runner.next;
    }

    SinglyLinkedListNode tail = new SinglyLinkedListNode(data);
    runner.next = tail;
    return head;

}