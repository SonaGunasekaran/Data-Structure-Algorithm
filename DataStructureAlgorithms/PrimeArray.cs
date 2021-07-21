using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureAlgorithms
{
    class PrimeArray
    {
        // Initialising 2d Array for prime numbers 
        public int[,] primeNum = new int[10, 100];
        int[] prime = new int[10];

        public void PrimeRange()
        {
            int num = 2;
            int k = 0;
            for (int i = 0; i < 10; i++)
            {
                k = 0;
                for (int j = 0; j < 100; j++)
                {
                    if (IsPrime(num))
                    {
                        primeNum[i, k] = num;
                        k++;
                    }
                    num++;
                }
                prime[i] = k;
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

