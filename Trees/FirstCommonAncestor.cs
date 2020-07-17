	//1. Find depth of each
	//2. Go up tree on deeper node until equal
	//3. Linearly go up tree until they equal same node



public Node FindCommon(Node A, Node B)
{
	int depthA = findDepth(A);
	int depthB = findDepth(B);

	if(depthA > depthB) {
		while (depthA > depthB)
		{
			A = A.parent;
			depthA--;
		}
	}
	else if (depthB > depthA) {
		while (depthB > depthA)
		{
			B = B.parent;
			DepthB--;
		}

	}

	while(A != B)
	{
		A = A.parent;
		B = B.parent;
	}

	Return A;


}