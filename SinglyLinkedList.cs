using System;

namespace Linked_List
{
    public class Node
    {
        public int data;
        public Node next;

        public Node(int value)
        {
            data = value;
            next = null;
        }
    }

    public class SinglyLinkedList
    {
        int length;
        Node head;

        public SinglyLinkedList()
        {
            head = null;
            length = 0;
        }

        public void AddNewNodeToHead(int data)
        {
            Node newNode = new Node(data);
            newNode.next = head;

            head = newNode;
            length++;
        }

        public void AddNewNodeToTail(int data)
        {
            Node newNode = new Node(data);
            newNode.next = null;

            if (head == null)
            {
                head = newNode;
                length++;

                return;
            }

            Node lastNode = GetLastNode();
            lastNode.next = newNode;
            length++;
        }

        public void AddAfter(Node prevNode, int data)
        {
            if (prevNode == null)
            {
                AddNewNodeToHead(data);
                length++;

                return;
            }

            Node newNode = new Node(data);
            newNode.next = prevNode.next;

            prevNode.next = newNode;
            length++;
        }

        public Node GetLastNode()
        {
            Node temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }

            return temp;
        }
        
        public Node GetCompleteNode()
        {
            return head;
        }

        public int GetSize()
        {
            return length;
        }

        public Node SearchForNode(int data)
        {
            Node nodes = head;

            while(nodes.next != null)
            {
                if (nodes.data == data)
                {
                    Console.WriteLine("Node found : " + nodes.data);
                    return nodes;
                }

                nodes = nodes.next;
            }

            Console.WriteLine("Node not found");
            return null;
        }

        public void ReserveNodes()
        {
            Node temp = head;
            Node nextNode = null;
            Node newNode = null;

            while(temp.next != null)
            {
                temp = temp.next;
                newNode.next = nextNode;
                
            }
        }

        public void DeleteNodeByValue()
        {
            
        }

        public void PrintSinglyLinkedList()
        {
            Node runner = head;
            while (runner != null)
            {
                Console.WriteLine(runner.data);
                runner = runner.next;
            }
        }
    }
}