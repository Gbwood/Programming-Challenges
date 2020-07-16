//in-Prder Traversal

public void inOrderTraversal(TreeNode node)
{
    if(node != null)
    {
        inOrderTraversal(node.left);
        visit(node);
        inOrderTraversal(node.right);
    }
}

public void preOrderTraversal(TreeNode node)
{
    if (node != null)
    {
        visit(node);
        inOrderTraversal(node.left);
        inOrderTraversal(node.right);
    }
}


public void postOrderTraversal(TreeNode node)
{
    if (node != null)
    {
        inOrderTraversal(node.left);
        inOrderTraversal(node.right);
        visit(node);
    }
}