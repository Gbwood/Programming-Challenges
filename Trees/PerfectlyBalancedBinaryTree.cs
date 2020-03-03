
// #Function to determine if a binary tree is perfectly balanced/mirrored 

public bool isBalanced(Node head) {
	Node leftHead;
	Node rightHead;
	
	if(head==null) {
		return true;
	}
	if(head.left != null && head.right != null) {
		leftHead = head.left;
		rightHead = head.right;
		Mirrored(leftHead, rightHead);
	}
	else return false;
	
}



public bool Mirrored (Node leftHead, Node rightHead) {
	
	#check left and right
	if (leftHead.left != null) {
		if (rightHead.right == null) return false;
	}
	else if (rightHead.right != null) return false;
	
	#check right and left
	if (leftHead.right != null) {
		if (rightHead.left == null) return false;
	}
	else if (rightHead.left != null) return false;
	
	
	if (leftHead.left != null) {
		if(!Mirrored(leftHead.left, rightHead.right)) return false;
	}
	if (leftHead.right != null) {
		if(!Mirrored(leftHead.right, rightHead.left)) return false;
	}
	
	return true;
	
	
}