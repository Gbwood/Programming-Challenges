//Given two singly linked lists, determine if the two lists intersect. Return the intersecting node. Node that the interesection is defined based on reference, not value. That is, if the 
//kth node of the first linked list is the exact same node by reference as the jth node of the second linked list, then they are intersecting.


public linkedListNode Intersect(linkedListNode n1, linkedListNode n2)
{
    int lengthN1 = 0;
    int lengthN2 = 0;
    linkedListNode startN1 = n1;
    linkedListNode startN2 = n2;

    while(n1.next || n2.next)
    {
        if(n1.next)
        {
            lengthN1++;
            n1.next = n1.next.next;
        }
        if (n2.next)
        {
            lengthN2++;
            n2.next = n2.next.next;
        }
    }

    if (n1 != n2) return null;

    LinkedListNode shorter = (lengthN1 < lengthN2 ? startN1 : startN2);
    LinkedListNode longer = (lengthN2 < lengthN2 ? startN2 : startN1);

    for (int i = 0; i < longer - shorter; i++)
    {
        longer = longer.next;
    }

    while (shorter != longer)
    {
        shorter = shorter.next;
        longer = longer.next;
    }
}