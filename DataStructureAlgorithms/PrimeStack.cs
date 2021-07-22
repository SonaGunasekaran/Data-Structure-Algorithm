using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureAlgorithms
{
    class PrimeStack<T>
    {
        private Node<T> top;

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

        public void Pop()
        {
            if (top == null)
            {
                Console.WriteLine("No elements to pop");

            }
            else
            {
                Console.WriteLine("{0}", top.value);
                top = top.Next;
            }
        }
        public int CheckTop()
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
