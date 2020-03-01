
//implement an algorith to find the kth to last element of a signly linked list

public LinkedListNode KthToLast(LinkedListNode node, int k)
{
    if (node == null) return null;
    LinkedListNode follower = node;
    int counter = 0;
    
    while(node.next != null)
    {
        counter++;
        node = node.next;
        if (counter - k >= 0)
        {
            follower = follower.next;
        }
    }
    if (counter - k < 0) return null;
    else return follower;
}