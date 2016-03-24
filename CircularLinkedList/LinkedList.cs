using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularLinkedList
{
    //1,3,2,3
    public class LinkedList
    {
        public Node head;
        public int Circular(Node head)
        {

            Node slow = head;
            Node fast = head;
            while (slow != null && fast != null && fast.next != null)
            {
                //Move slow pointer one step and fast pointer two steps
                slow = slow.next;
                fast = fast.next.next;
                //Find where slow and fast pointer meets
                if (slow == fast)
                    break;
            }
            //If there is no meeting point then exit
            if (fast == null || fast.next == null)
                return -1;
            //Move slow pointer to head and keep fast at the meeting point 
            slow = head;
             while(slow!=fast)
            {
                /***Move slow pointer and fast pointer at speed of one step. 
                If they both move at the same rate then they will meet at loop start***/
                slow = slow.next;
                fast = fast.next;
             }
            //return the new meeting point
            return fast.data;
            }
            
        

        public void PrintList()
        {
            Node n = head;
            while(n!=null)
            {
                Console.WriteLine(n.data + "->");
                n = n.next;
            }
        }
    }
}
