using CodingQuestions.Graph;

namespace CodingQuestions
{


    public class Program
    {
        public static void Main(string[] args)
        {
            List llist = new List();

            llist.AppendNode(10);
            llist.AppendNode(20);
            llist.AppendNode(30);
            llist.AppendNode(40);
            llist.AppendNode(50);
            llist.PrependNode(100);



            Console.WriteLine("---------------- ConsoleApp ----------------");

            // llist.PrintList();
            // KthNodeTest();
            // SparseVectorTest();
            // BSTTest();
            TestGraph();

            Console.WriteLine("str to Int, " + StringToInt.stringToInt("123").ToString());
            Console.WriteLine("str to Int, " + StringToInt.stringToInt("-123").ToString());

            Console.WriteLine("---------------- End -----------------------");
            Console.ReadKey();
        }

        public static void TestGraph()
        {
            Graph g = new Graph(5);
            g.addEdge(0, 1);
            g.addEdge(1, 2);
            g.addEdge(2, 3);
            g.addEdge(2, 4);
            g.addEdge(4, 2);
            g.addEdge(3, 0);

            g.Print();
        }


        public static void BSTTest()
        {
            var root = new TreeNode(4);
            root.left = new TreeNode(1);
            root.right = new TreeNode(6);

            root.left.left = new TreeNode(0);
            root.left.right = new TreeNode(2);
            root.left.right.right = new TreeNode(3);

            root.right.left = new TreeNode(5);
            root.right.right = new TreeNode(7);
            root.right.right.right = new TreeNode(8);

            var Bst = new BST(root);
            Bst.PrintBST(root);

            Bst.BSTToGst(root, 0);

            Bst.PrintBST(root);
        }

        public static void SparseVectorTest()
        {
            int[] n1 = { 0, 1, 0, 0, 2, 0, 0 };
            int[] n2 = { 1, 0, 0, 0, 3, 0, 4 };
            var vec1 = new SpaceVector(n1);
            var vec2 = new SpaceVector(n2);

            Console.WriteLine(vec1.DotProduct(vec2));
        }

        public static void ReverseTest(KthNode kthNode)
        {
            Console.WriteLine("Reversed list - ");
            kthNode.ReverseList();
        }

        public static void KthNodeTest()
        {
            KthNode kthNode = new KthNode();
            kthNode.Append(10);
            kthNode.Append(20);
            kthNode.Append(30);
            kthNode.Append(40);
            kthNode.Append(50);
            kthNode.Append(100);
            kthNode.Append(70);
            kthNode.Append(80);
            kthNode.Append(90);

            kthNode.PrintList();

            var node = kthNode.GetKthNode(3);
            Console.WriteLine($"Kth node -  {node?.data}");

            ReverseTest(kthNode);
        }

        public static void LinkedListTest()
        {
            string[] words =
            { "the", "fox", "jumps", "over", "the", "dog" };

            LinkedList<string> list = new LinkedList<string>(words);
            LinkedListNode<string> first = list.AddLast("a");
            var node = list.AddLast("b");

            var nodec = list.AddLast("c");
            list.AddLast("d");

            List<string> list2 = new List<string>(list);
            Console.WriteLine("Singly list - ");
            foreach (var item in list2)
            {
                Console.WriteLine(item);
            }



            try
            {
                list.AddBefore(node, "ab");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            list.AddAfter(nodec, "cd");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}