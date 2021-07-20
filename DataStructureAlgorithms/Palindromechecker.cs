using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureAlgorithms
{
    class Palindromechecker<T>
    {
        Node<T> front;
        Node<T> rear;

        public T Enqueue(T value)
        {
            Node<T> queue = new Node<T>(value);
            if (front == null)
            {
                front = queue;
            }
            else
            {
                Node<T> rear = front;
                while (rear.Next != null)
                {
                    rear = rear.Next;
                }
                rear.Next = queue;
            }
            return value;
        }

           
        public T DequeueFront()
        {
            T value;
            if (front == null)
            {
                Console.WriteLine("No elements");
                return default;
            }
            else
            {
                Node<T> temp = front;
                value = front.value;
                front = front.Next;
                temp.Next = null;
            }
            return value;
        }
        public T DequeueRear()
        {
            T value;
            if (rear == null)
            {
                return default;
            }
            else
            {
             Node<T> temp = rear;
             value = rear.value;
             rear = rear.Next;
             temp.Next = null;
            }
            return value;
        }
        public int CheckEquality()
        {
            if (front == rear)
            {
               return 0;
            }
            if (front == null || rear == null)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }
}
