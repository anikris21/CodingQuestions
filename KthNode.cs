using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingQuestions
{

    public class KthNode
    {
        private Node? head = null;

        public class Node
        {
            public int data;
            public Node? next;
            
            public Node(int data)
            {
                this.data = data;
                this.next = null;
            }
        }

        public Node? Append(int data)
        {
            Node? node = new Node(data);
            if(head == null)
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

        public Node? Prepend(int data)
        {
            Node node = new Node(data);

            node.next = head;
            return node;
        }

        public void PrintList()
        {
            Node? curr = head;

            while(curr != null)
            {
                Console.WriteLine(curr.data);
                curr = curr.next;
            }
        }

        public void ReverseList()
        {
            Stack<Node> stack = new Stack<Node>();

            while(head != null)
            {
                stack.Push(head);
                head= head.next;
            }

            while(stack.Count > 0)
            {
                var node = stack.Pop();
                Console.WriteLine(node.data);
            }
            
        }

        public Node? GetKthNode(int k)
        {
            int count = 0;
            Node? node = head;
            while(count < k)
            {
                count++;
                node = node.next;
            }

            Node? curr = head;
            while(node != null)
            {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                curr = curr.next;
#pragma warning restore CS8602 // Dereference of a possibly null reference.
                node = node.next;
            }

            return curr;
        }
    }
}
