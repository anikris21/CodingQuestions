using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingQuestions
{
    public class BST
    {
        public TreeNode? root;

        public BST(TreeNode? treeNode)
        {
            root = treeNode;
        }

        public int BSTToGst(TreeNode? root, int rootSum)
        {
            if(root == null)
            {
                return 0;
            }

            int val = BSTToGst(root.right, rootSum);
            int ret = val + root.data;
            // Gst
            root.data = ret + rootSum;

            ret += BSTToGst(root.left, root.data);

            return ret;
        }

        public void PrintBST(TreeNode? root)
        {
            if( root == null)
            {
                return;
            }

            PrintBST(root.left);
            Console.WriteLine(root.data);
            PrintBST(root.right);
        }

    }
}
