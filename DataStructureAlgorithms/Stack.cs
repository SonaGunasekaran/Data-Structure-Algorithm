using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureAlgorithms
{
    class Stack<T>
    {
        public Node<T> top;

        public void Push(T value)
        {
            Node<T> newNode = new Node<T>(value);
            if (top == null)
            {
                top = newNode;
            }
            else
            {
                newNode.Next = top;
                top = newNode;
            }
        }
        public int Pop()
        {
            if (top == null)
            {
                return 0;
            }
            else
            {
                top = top.Next;
                return 1;
            }
        }
        public int CheckParanthesis()
        {
            if (top == null)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
