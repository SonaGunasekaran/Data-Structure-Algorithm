using System;
using System.IO;

namespace DataStructureAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Data Structures Algorithm Programs!");
            UnorderedList <string> unOrdered = new UnorderedList <string>();
            //created a text file
            string filePath = @"C:\Users\Sona G\source\repos\DataStructureAlgorithms\DataStructureAlgorithms\wordFile.txt";
            string text = File.ReadAllText(filePath);
            string[] stringArray = text.Split(" ");
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
        }
    }
}
