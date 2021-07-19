using System;
using System.IO;

namespace DataStructureAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Data Structures Algorithm Programs!");
            OrderedList <string> ordered = new OrderedList <string>();
            //created a text file
            string filePath = @"C:\Users\Sona G\source\repos\DataStructureAlgorithms\DataStructureAlgorithms\wordFile.txt";
            string text = File.ReadAllText(filePath);
            string[] stringArray = text.Split(" ");
            for (int i = 0; i < stringArray.Length; i++)
            {
                ordered.Add(stringArray[i]);
            }
            //Get the input from user
            Console.WriteLine("Enter the word to searched:");
            string word = Console.ReadLine();
            int found = ordered.SearchNode(word);
            if (found == 1)
            {
                ordered.DeleteNode(word);
            }
            else
            {
                ordered.Add(word);
            }
            string data = ordered.Display();
            File.WriteAllText(filePath, data);
        }
    }
}
