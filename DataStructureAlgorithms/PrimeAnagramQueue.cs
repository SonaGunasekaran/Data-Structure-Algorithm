using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureAlgorithms
{
    class PrimeAnagramQueue<T>
    {
       private Node<T> top;
       private Node<T> front;
       private Node<T> rear;
       public void Enqueue(T value)
       {
          Node<T> newNode = new Node<T>(value); 
          if (front == null)
          {
             front = newNode;
          }
          else
          {
             rear = front;
             while (rear.Next != null)
             {
                rear = rear.Next;
             }
              rear.Next = newNode;
          }
       }
       public void Deque()
       {
           rear = front;
           if (rear == null)
           {
              Console.WriteLine("No element in the list");
           }
           else
           {
              front = front.Next;
           }
           Console.WriteLine("{0} ", rear.value);
       }
       public int CheckFront()
       {
           if (front == null)
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

