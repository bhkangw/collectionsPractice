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

            //Displays the multiplication table
            for (int x = 0; x < 10; x++)
            {
                string display = "[ ";
                for (int y = 0; y < 10; y++)
                {
                    display += mult[x, y] + ", ";
                    //Add an extra space for single digit values
                    if (mult[x, y] < 10)
                    {
                        display += " ";
                    }
                }
                display += "]";
                Console.WriteLine(display);
            }

            // List of Flavors
            // Create a list of Ice Cream flavors that holds at least 5 different flavors
            List<string> flavors = new List<string>();
            flavors.Add("Vanilla");
            flavors.Add("Chocolate");
            flavors.Add("Strawberry");
            flavors.Add("Pistacio");
            flavors.Add("Rocky Road");
            flavors.Add("Cheesecake");
            flavors.Add("Birthday Cake");
            // Output the length of this list after building it
            Console.WriteLine(flavors.Count);
            // Output the third flavor in the list, then remove this value.
            Console.WriteLine("The third flavor in the list is: " + flavors[2]);
            flavors.RemoveAt(2);
            // Output the new length of the list(Note it should just be one less~)
            Console.WriteLine(flavors.Count);

            // User Info Dictionary
            // Create a Dictionary that will store both string keys as well as string values
            Dictionary<string, string> userInfo = new Dictionary<string, string>();
            // For each name in the array of names you made previously, add it as a new key in this dictionary with value null
            foreach(string name in nameArray){
                userInfo.Add(name,null);
            }
            // For each name key, select a random flavor from the flavor list above and store it as the value
            Random rand = new Random();
            foreach (string name in nameArray)
            {
                userInfo[name] = flavors[rand.Next(flavors.Count)];
            }
            // Loop through the Dictionary and print out each user's name and their associated ice cream flavor.
            Console.WriteLine("Users and their favor ice cream flavors:");
            foreach (KeyValuePair<string, string> info in userInfo)
            {
                Console.WriteLine(info.Key + " - " + info.Value);
            }
        }
    }
}
