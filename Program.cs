using System;

namespace Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("__________________________________ Linked List __________________________________");

            SinglyLinkedList sll = new SinglyLinkedList();
            sll.AddNewNodeToHead(1);
            sll.AddNewNodeToHead(2);
            sll.AddNewNodeToHead(3);
            sll.AddNewNodeToHead(4);
            sll.AddNewNodeToHead(5);
            sll.AddNewNodeToHead(6);
            sll.AddNewNodeToTail(0);
            sll.AddNewNodeToTail(-1);
            sll.AddAfter(sll.GetCompleteNode().next.next, 100);
            sll.SearchForNode(51);

            sll.PrintSinglyLinkedList();

            Console.WriteLine("Length : " + sll.GetSize().ToString());
        }
    }
}
