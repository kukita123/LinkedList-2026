using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList_2026
{
    #region 1va grupa
    internal class MyLinkedList
    {
        private class Node
        {
            //data for the node:
            public int value;
            //pointer to the next node:
            public Node next;

            //constructor for the node:
            public Node(int value)
            {
                this.value = value;
                this.next = null;
            }
        }

        //data members for the linked list:
        private Node first;
        private Node last;
        private int size;
        public int Size
        {
            get { return size; }
        }
        private bool isEmpty()
        {
            return first == null;
        }
        //Add a new node at the beginning of the list:
        public void AddFirst(int value)
        {
            Node newNode = new Node(value);

            if (isEmpty())  //empty list 
            {
                //linked list with one element
                first = newNode;
                last = newNode;
                //first = last = newNode;
            }
            else
            {
                newNode.next = first;
                first = newNode;
            }
            size++;
        }
        public void AddLast(int value)
        {
            Node newNode = new Node(value);
            if (isEmpty())  //empty list 
            {
                //linked list with one element
                first = newNode;
                last = newNode;
                //first = last = newNode;
            }
            else
            {
                last.next = newNode;
                last = newNode;
            }
            size++;
        }
    }
    #endregion
}
