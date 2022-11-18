using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingQuestions
{
    public class ValidateBST
    {
        public static bool isBST(TreeNode? treeNode, int min, int max)
        {
            if (treeNode == null)
            {
                return true;
            }

            if(treeNode.data >= min && treeNode.data < max)
            {
                return isBST(treeNode.left, min, treeNode.data) && 
                    isBST(treeNode.right, treeNode.data, max);
            }

            return false;
        }
    }
}
