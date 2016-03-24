using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularLinkedList
{
    //Write an algorithm to determine if a linkedlist is circular. FOLLOW UP: Determine where the circle meets. 
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.head = new Node(1);
            Node second = new Node(3);
            Node third = new Node(2);
            Node four = new Node(3);
            list.head.next = second;
            list.head.next.next = third;
            list.head.next.next.next = four;
            four.next = list.head.next;
           


            Console.WriteLine(list.Circular(list.head)); 
            //list.PrintList();
        }
    }
}
