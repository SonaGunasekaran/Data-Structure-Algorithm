using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureAlgorithms
{
   public class UnorderedList<T>
   {
        private Node<T> head;
        public void AddLast(T value)
        {
            //creating the new node with given value
            Node<T> newNode = new Node<T>(value);
            //check whether the head is null or not . 
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node<T> temp = head;
                //repeat until temp.Next becomes null
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = newNode;
            }
        }
        public void DeleteNode(T value)
        {
            //check whether the head is null or not . 
            if (head == null)
            {
                Console.WriteLine("List is empty");
            }
            else if (head.value.Equals(value))
            {
                head = head.Next;
            }
            else
            {
               
                Node<T> prev = head;
                Node<T> temp = head;
                //repeat until temp becomes null
                while (temp != null && !(temp.value.Equals(value)))
                {
                    prev = temp;
                    temp = temp.Next;
                }
                //if the node is equal to search node then delete the node 
                if (temp.value.Equals(value))
                {
                    prev.Next = temp.Next;
                    temp.Next = null;
                }

            }
        }
        public int SearchNode(T value)
        {
            //check whether the head is null or not . 
            if (head == null)
            {
                return 0;
            }
            else
            {
                Node<T> temp = head;
                //repeat until temp becomes null
                while (temp.Next != null && !(temp.value.Equals(value)))
                {
                    temp = temp.Next;
                }
                //if the node is equal to search node then return 1
                if (temp.value.Equals(value))
                {
                    return 1;
                }
                return 0;
            }
        }
        public string Display()
        {
            Node<T> temp = head;
            string data = "";
            //check whether the head is null or not
            if (head == null)
            {
                Console.WriteLine("No element is present in the list");
            }
            else
            {
                while (temp.Next != null)
                {
                    Console.WriteLine("" + temp.value);
                    data = data + temp.value + " ";
                    temp = temp.Next;
                }
                data = data + temp.value;
            }
            return data;
        }
    }
}
