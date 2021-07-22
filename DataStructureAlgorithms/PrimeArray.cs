using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureAlgorithms
{
    class PrimeArray<T>
    {
        // Initialising 2d Array for prime numbers 
        public int[,] primeNum = new int[10, 100];
        int p = 0, q = 0;
        int count = 0;
        int[] array = new int[1000];
       // int[,] anagram = new int[10, 100];
        int[] primeAnagram = new int[10];
        int[] prime = new int[10];
        PrimeStack<int> anagram = new PrimeStack<int>();
        public void PrimeRange()
        {
            int value = 2;
            int k = 0;
            for (int i = 0; i < 10; i++)
            {
                k = 0;
                for (int j = 0; j < 100; j++)
                {
                    if (IsPrime(value))
                    {
                        primeNum[i, k] = value;
                        array[count] = value;
                        k++;
                        count++;
                    }
                    value++;
                }
                prime[i] = k;
            }
        }
        //check for Anagram
        public bool CheckAnagram(string str1, string str2)
        {
            bool isAnagram = false;
            char[] char1 = str1.ToCharArray();
            char[] char2 = str2.ToCharArray();
            Array.Sort(char1);
            Array.Sort(char2);
            String s1 = new String(char1);
            String s2 = new String(char2);
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1.Equals(s2))
                {
                    isAnagram = true;
                }
                else
                {
                    isAnagram = false;
                    break;
                }
            }
            return isAnagram;
        }
        
        public void AnagramRange()
        {
            int num = 100;
            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < count; j++)
                {
                    if (array[i] == array[j])
                    {
                        continue;
                    }
                    if (CheckAnagram(array[i].ToString(), array[j].ToString()))
                    {
                        anagram.Push(array[i]);
                        break;
                    }
                }
            }
        }
        //Printing PrimeArray
        public void Print()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    if (primeNum[i, j] != 0)
                    {
                        Console.WriteLine(primeNum[i, j]);
                    }
                }
                Console.WriteLine( );
            }
        }
        //Printing Anagram
        public void PrintAnagram()
        {
            while (anagram.CheckTop() == 0)
            {
                anagram.Pop();
            }
            Console.WriteLine();
        }
        //Check for prime
        public bool IsPrime(int i)
        {
            int j, flag;
            bool findPrime = false;

            // Skip 0 and 1 as they are
            // neither prime nor composite
            if (i == 1 || i == 0)
                findPrime = false;

            // flag variable to tell
            // if i is prime or not
            flag = 1;
            for (j = 2; j <= i / 2; ++j)
            {
                if (i % j == 0)
                {
                   flag = 0;
                    break;
                }
            }
            // flag = 1 means i is prime
            // and flag = 0 means i is not prime
            if (flag == 1)
            {
              findPrime = true;
            }
            return findPrime;
        }
            
    }
}

