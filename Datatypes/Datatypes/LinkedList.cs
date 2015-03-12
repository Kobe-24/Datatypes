using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datatypes
{
    public class LinkedList
    {
        private Node head;

        public LinkedList()
        {

        }

        public override string ToString()
        {
            string stringToReturn = "";
            if (head != null)
            {
                stringToReturn = head.Data.ToString();
                Node currentNode = head.Next;
                while (currentNode != null)
                {
                    stringToReturn += "\n" + currentNode.Data.ToString();
                    currentNode = currentNode.Next;
                }
            }

            return stringToReturn;
        }

    
        public object this[int i] 
        {
            get
            {
                Node pointer = head;
                for (int k = 0; k < i; k++)
                {
                    if (pointer == null) throw new Exception("integer larger than size of list");
                    pointer = pointer.Next;
                }
                return pointer.Data;
            }

        }

        public void Add(object data)
        {
            var newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
                return;
            }

            Node currentNode = head;
            while (currentNode.Next != null)
            {
                currentNode = currentNode.Next;
            }

            currentNode.Next = newNode;
            return;
        }

//        prev = null;
//        current = head;
//        next = current->next;

//        (while next != null)
//              current->next=prev
//              prev=current
//              current=next
//              next=current->next
        public void Reverse()
        {
            if (head == null || head.Next == null)
            {
                return;
            }

            var currentNode = head;
            Node previousNode = null;
            Node nextNode;

            while (currentNode.Next != null)
            {
                nextNode = new Node(currentNode.Next);
                currentNode.Next = previousNode;

                previousNode = currentNode;
                currentNode = nextNode;
            }

            currentNode.Next = previousNode;
            head = currentNode;

        }


        private class Node
        {
            public Node Next { get; set; }

            public object Data { get; set; }

            public Node(object data)
            {
                this.Data = data;
            }

            //copy constructor
            public Node(Node node)
            {
                this.Next = node.Next;
                this.Data = node.Data;
            }

        }

    }
}
