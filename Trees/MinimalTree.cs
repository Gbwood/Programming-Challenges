//Given a sorted increasing order array with unique integer elements, write an algorithm to create a binary search tree with minimal height


//Array 1: [1,2,3,4,5,6,7,8,9,10] 2: [1,2,3,4,5,6,7,8,9]
//by using a binary search method on the array we can create an efficient binary search tree

using System;
using System.Collections.Generic;

public node minimalTree(int[] a)
{
    
    if (a.Length > 1)
    {
        int highIndex = a.Length - 1;
        TreeNode node = new TreeNode();
        node.value = a[highIndex / 2];

        node.left = (minimalTree(a[0..((highIndex / 2)-1)]));
        node.right = minamlTree(a[(highIndex / 2 + 1)..(highIndex)]);
        return node;
    }

    return null;
}