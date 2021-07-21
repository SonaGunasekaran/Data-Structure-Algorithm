using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureAlgorithms
{
    class CashCounter<T> where T : IComparable
    {
        Node<T> front;
        Node<T> rear;
        int balance = 10000;
        public void Accholder()
        {
            List<T> accHolderName = new List<T>();
            foreach(T x in accHolderName)
            {
                Enqueue(x);
            }
            DisplayList();
            while (Size() > 0)
            {
                //while size of queue greater than 0 perform operation
                Operation();
                DisplayList();
            }

        }

        public void Operation()
        {
            Console.WriteLine("\n1.Deposit\n2.Withdraw\n3.Exit");
            Console.WriteLine("Enter your option");
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    Console.WriteLine("Enter Amount to Deposit");
                    int amount = Convert.ToInt32(Console.ReadLine());
                    balance += amount;
                    Console.WriteLine($"Deposited {amount} to the bank");
                    Console.WriteLine($"Total Bank Balance --> {balance}");
                    Dequeue();
                    break;
                case 2:

                    int amountWithdraw;
                    while (true)
                    {
                        Console.WriteLine("Enter Amount to Withdraw");
                         amountWithdraw = Convert.ToInt32(Console.ReadLine());

                        if (amountWithdraw > balance)
                        {
                            Console.WriteLine("Not Enough Money present");
                        }
                        else
                        {
                            balance -= amountWithdraw;
                            break;
                        }
                    }
                    Console.WriteLine($" Withdrawed {amountWithdraw} from the bank");
                    Console.WriteLine($"Total Bank Balance --> {this.balance}");
                    //remove person from the queue after his operation performed
                    Dequeue();
                    break;
                case 3:
                    //remove person from the queue if he wants to exit
                    Dequeue();
                    break;
              }

        }
            //method to insert the element in front;
        public void Enqueue(T value)
        {
            //creating the new node with given value
            Node<T> newNode = new Node<T>(value);
            //check whether the front is null or not . 
            if (front == null)
            {
               front = newNode;
            }
            //make ne element as head
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
        public void Dequeue()
        {
            if (front == null)
            {
                Console.WriteLine("No elements");
            }
            else
            {
                Node<T> temp = front;
                front = front.Next;
                temp.Next = null;
            }
        }
        //public void DisplayList()
        //{
        //    rear = front;
        //    //if head is null then no element is present
        //    if (front == null)
        //    {
        //        Console.WriteLine("No element in the list");
        //    }
        //    //else until temp become null print the elements 
        //    else
        //    {
        //        Node<T> temp = this.front;
        //        while (temp != null)
        //        {
        //            Console.Write($"|__{temp.value}__|");
        //            temp = temp.Next;
        //        }
        //    }
        //}
        public void DisplayList()
        {
            Console.WriteLine("\n");
            Node<T> temp = this.front;
            while (temp != null)
            {
                Console.Write($"|__{temp.value}__|");
                temp = temp.Next;
            }
        }

        public int Size()
        {
            int count = 0;
            Node<T> temp = this.front;
            while (temp != null)
            {
                count++;
                temp = temp.Next;
            }
            return count;
        }

    }
}
