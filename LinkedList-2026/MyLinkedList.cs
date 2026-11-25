using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList_2026
{
    #region 1va grupa
    //internal class MyLinkedList
    //{
    //    private class Node
    //    {
    //        //data for the node:
    //        public int value;
    //        //pointer to the next node:
    //        public Node next;

    //        //constructor for the node:
    //        public Node(int value)
    //        {
    //            this.value = value;
    //            this.next = null;
    //        }
    //    }

    //    //data members for the linked list:
    //    private Node first;
    //    private Node last;
    //    private int size;
    //    public int Size
    //    {
    //        get { return size; }
    //    }
    //    private bool isEmpty()
    //    {
    //        return first == null;
    //    }
    //    //Add a new node at the beginning of the list:
    //    public void AddFirst(int value)
    //    {
    //        Node newNode = new Node(value);

    //        if (isEmpty())  //empty list 
    //        {
    //            //linked list with one element
    //            first = newNode;
    //            last = newNode;
    //            //first = last = newNode;
    //        }
    //        else
    //        {
    //            newNode.next = first;
    //            first = newNode;
    //        }
    //        size++;
    //    }
    //    public void AddLast(int value)
    //    {
    //        Node newNode = new Node(value);
    //        if (isEmpty())  //empty list 
    //        {
    //            //linked list with one element
    //            first = newNode;
    //            last = newNode;
    //            //first = last = newNode;
    //        }
    //        else
    //        {
    //            last.next = newNode;
    //            last = newNode;
    //        }
    //        size++;
    //    }
    //}
    #endregion

    #region 2ra grupa
    internal class MyLinkedList
    {
        private class Node
        {
            public int value;
            public Node next;

            //Node constructor:
            public Node(int value)
            {
                this.value = value;
                this.next = null;
            }
        }

        private Node first; //object - node
        private Node last;  //object - node
        private int size;

        public int Size
        {
            get { return size; }
        }

        private bool IsEmpty()
        {
            return first == null;
        }
        public void AddFirst(int value)
        {
            Node newNode = new Node(value); //new object - node to add to the begining of the list

            if (IsEmpty())       //empty list
            {
                first = newNode;
                last = newNode;
            }
            else
            {
                newNode.next = first;  //new node points to the previous first node
                first = newNode;  //first points to the new node
            }
            size++;
        }
        public void AddLast(int value)
        {
            Node newNode = new Node(value); //new object - node to add to the end of the list

            if (IsEmpty())       //empty list
            {
                first = last = newNode;                
            }
            else
            {
                last.next = newNode;  //previous last node points to the new node
                last = newNode;  //last points to the new node
            }
            size++;
        }
    }
     #endregion

}
