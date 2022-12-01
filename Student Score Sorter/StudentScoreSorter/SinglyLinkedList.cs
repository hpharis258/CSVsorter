using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentScoreSorter
{
    public class SinglyLinkedList
    {
        public Node head = null;
        // Merge Sort
        public Node mergeSort(Node head)
        {
            // If Null checks 
            if (head == null || head.nextNode == null)
            {
                return head;
            }
            // Get Middle
            Node middle = GetMiddle(head);
            Node oneAfterMiddle = middle.nextNode;
            // Set the Node after middle to Null
            middle.nextNode = null;
            // Merge Sort Left Half
            Node left = mergeSort(head);
            // Merge Sort Right Half
            Node right = mergeSort(oneAfterMiddle);
            // Merge Sorted Lists
            Node sortedList = sortedMerge(left, right);
            return sortedList;
        }

        // Get Middle, Utility Method Gets the Middle of the Linked List
        public Node GetMiddle(Node head)
        {
            // Best Case
            if(head == null)
            {
                return head;
            }
            // Fast Pointer
            Node pointer1 = head.nextNode;
            // Slow Pointer
            Node pointer2 = head;
            // Move pointer one By two 
            // Move Pointer 2 by one
            // Pointer one will point to the Middle
            while(pointer1 != null)
            {
                pointer1 = pointer1.nextNode;
                if(pointer1 != null)
                {
                    pointer2 = pointer2.nextNode;
                    pointer1 = pointer1.nextNode;
                }
            }
            return pointer2;
        }
        // Add new Data
        public void add(string data)
        {
            Node created = new Node(data);
            // Link the Old head
            created.nextNode = head;
            // Point head to the new Node
            head = created;
        }

        //  Merge back the Sorted Parts
        public Node sortedMerge(Node a, Node b)
        {
            Node result = null;
            // Base Case
            if(a == null)
            {
                return b;
            }
            if(b == null)
            {
                return a;
            }
            // Pick either A or B 
            if(a.score <= b.score) 
            {
                result = a;
                result.nextNode = sortedMerge(a.nextNode, b);
            }
            else
            {
                result = b;
                result.nextNode = sortedMerge(a,b.nextNode);
            }
            return result;  
        }
    }
}
