using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingQuestions
{
    

    public class List
    {
        public Node? head = null;

        public Node? AppendNode(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
                return node;
            }

            Node? curr = head;
            while(curr.next != null)
            {
                curr = curr.next;
            }
            curr.next = node;

            return head;
        }

        public Node? PrependNode(int data)
        {
            Node node = new Node(data);
            node.next = head;

            return node;
        }

        public void PrintList()
        {
            Node? node = head;

            while(node != null)
            {
                Console.WriteLine(node.data);
                node = node.next;
            }
        }

    }
}
