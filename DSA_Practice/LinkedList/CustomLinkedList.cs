using System;

namespace DSA_Practice.LinkedList
{
    public class CustomLinkedList
    {
        internal class Node
        {
            private int value;
            internal Node next;

            public Node(int value)
            {
                this.value = value;
            }

            public int Value => value;
        }

        private Node head;
        private Node tail; // 10, 20

        public void Traverse()
        {
            if (head == null) return;
            var temp = head;
            while (temp != null)
            {
                Console.WriteLine(temp.Value);
                temp = temp.next;
            }
        }
        public void AddToFirst(int value)
        {
            var node = new Node(value);
            if (head == null)
            {
                head = tail = node;
                return;
            }

            node.next = head;
            head = node;
        }

        public void AddToLast(int value)
        {
            var node = new Node(value);
            if (head == null)
            {
                head = tail = node;
                return;
            }
            
            // traverse to last node
            var temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }

            temp.next = node;
            tail = node;
        }

        public void RemoveFirst()
        {
            if(head == null) return;
            head = head.next;
        }

        public void RemoveLast()
        {
            if(head == null) return;
            var temp = head;
        }
    }
}