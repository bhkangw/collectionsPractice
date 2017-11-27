using System;
using System.Collections.Generic;

namespace collectionsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3 basic arrays
            // Create an array to hold integer values 0 through 9
            int[] valArray = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            // Create an array of the names "Tim", "Martin", "Nikki", &"Sara"
            string[] nameArray = new string[] { "Tim", "Martin", "Nikki", "Sara" };
            // Create an array of length 10 that alternates between true and false values, starting with true
            bool[] boolArray = new bool[10];
            for(int i = 0; i < 10; i+=2)
            {
                boolArray[i] = true;
            }

            // Multiplication Table
            int[,] mult = new int[10, 10];
            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    mult[x, y] = (x + 1) * (y + 1);
                }
            }
        }
    }
}
