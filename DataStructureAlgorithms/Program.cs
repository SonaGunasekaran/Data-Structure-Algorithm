using System;
using System.Collections.Generic;
using System.IO;

namespace DataStructureAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Data Structures Algorithm Programs!");

            //created a text file
            string filePath = @"C:\Users\Sona G\source\repos\DataStructureAlgorithms\DataStructureAlgorithms\wordFile.txt";
            string text = File.ReadAllText(filePath);
            string[] stringArray = text.Split(" ");

            Console.WriteLine("1.Unordered List\n2.Ordered List\n3.Balanced Paranthesis\n4.Palindrome Checker\n5.PrimeArray");
            Console.WriteLine("Enter Your Option");
            int choice = (Convert.ToInt32(Console.ReadLine()));
            switch (choice)
            {

                case 1:
                    UnorderedList<string> unOrdered = new UnorderedList<string>();
                    for (int i = 0; i < stringArray.Length; i++)
                    {
                        unOrdered.AddLast(stringArray[i]);
                    }
                    //Get the input from user
                    Console.WriteLine("Enter the word to searched:");
                    string word = Console.ReadLine();
                    int found = unOrdered.SearchNode(word);
                    if (found == 1)
                    {
                        unOrdered.DeleteNode(word);
                    }
                    else
                    {
                        unOrdered.AddLast(word);
                    }
                    string data = unOrdered.Display();
                    File.WriteAllText(filePath, data);
                    break;

                case 2:
                    OrderedList<string> ordered = new OrderedList<string>();
                    for (int i = 0; i < stringArray.Length; i++)
                    {
                        ordered.Add(stringArray[i]);
                    }
                    //Get the input from user
                    Console.WriteLine("Enter the word to searched:");
                    string wordOrdered = Console.ReadLine();
                    int found1 = ordered.SearchNode(wordOrdered);
                    if (found1 == 1)
                    {
                        ordered.DeleteNode(wordOrdered);
                    }
                    else
                    {
                        ordered.Add(wordOrdered);
                    }
                    string data1 = ordered.Display();
                    File.WriteAllText(filePath, data1);
                    break;
                case 3:
                    Stack<char> stack = new Stack<char>();
                    string expression = "(5+6)∗(7+8)/(4+3)(5+6)∗(7+8)/(4+3)";
                    for (int i = 0; i < expression.Length; i++)
                    {
                        if (expression[i].Equals('('))
                        {
                            stack.Push(expression[i]);
                        }
                        else if (expression[i].Equals(')'))
                        {
                            stack.Pop();
                        }
                    }
                    if (stack.CheckParanthesis() == 1)
                    {
                        Console.WriteLine("Arithmetic Expression is balanced");
                    }
                    else
                    {
                        Console.WriteLine("Arithmetic Expression is unbalanced");
                    }
                    break;
                case 4:
                    Palindromechecker<char> queue = new Palindromechecker<char>();
                    int flag = 1;
                    string word2 = "kala";
                    for (int i = 0; i < word2.Length; i++)
                    {
                        queue.Enqueue(word2[i]);
                    }
                    while (queue.CheckEquality() == 1)
                    {
                        if (!(queue.DequeueFront().Equals(queue.DequeueRear())))
                        {
                            flag = 0;
                            break;
                        }
                    }
                    if (flag == 1)
                    {
                        Console.WriteLine("String is palindrome");
                    }
                    else
                    {
                        Console.WriteLine("String is not palindrome");
                    }
                 break;
                case 5:
                    PrimeArray<int> prime = new PrimeArray<int>();
                    prime.PrimeRange();
                    prime.Print();
                    prime.AnagramRange();
                    prime.PrintAnagram();
                    break;
                case 6:
                    BankDetails account;
                    LinkedList<BankDetails> bankAccountsList = new LinkedList<BankDetails>();
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine("Enter account holder name:");
                        string name = Console.ReadLine();
                        Console.WriteLine("enter amount:");
                        int amount = Convert.ToInt32(Console.ReadLine());
                        account = new BankDetails(name, amount);
                        bankAccountsList.AddLast(account);

                    }
                  CashCounter<string> cashCounter = new CashCounter<string>();
                    //cashCounter.Accholder(bankAccountsList);
                    cashCounter.Operation();

                    break;

                    default:
                    Console.WriteLine("Exit");
                    break;
            }
        }
    }
}


