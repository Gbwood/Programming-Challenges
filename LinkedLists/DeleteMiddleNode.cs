//Implenent an algorith to delete a node in the middle of a singly linked list given only access to that node

//I do not have access to the previous node so there is no way I can change the previous nodes next property. So it must point to current node. 
//I can replace this nodes value with the following node and then delete that node


public bool DeleteMiddleNode(LinkedListNode n)
{
	if (n == null || n.next == null) return false;

	n.data = n.next.value;
	n.next = n.next.next;
	return false;
}