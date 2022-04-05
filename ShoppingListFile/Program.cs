using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ShoppingListFile
{
    class Program
    {
        static void Main(string[] args)
        {
            ShoppingListFile(); 
        }
        private static void ShoppingListFile()
        {
            string fileLocation = @"C:\Users\...\samples\ShoppingList";
            string fileName = @"\\ShoppingListFile.txt";

            string[] arrayFromFile = File.ReadAllLines($"{fileLocation}{fileName}");
            List<string> myWishList = arrayFromFile.ToList<string>();

            bool loopActive = true;

            while (loopActive)
            {
                Console.WriteLine("Would you like to add a wish? Y/N?:");

                char userInput = Convert.ToChar(Console.ReadLine().ToLower());

                if (userInput == 'y')
                {
                    Console.WriteLine("Enter your wish:");
                    string userWish = Console.ReadLine();
                    myWishList.Add(userWish);
                }
                else
                {
                    loopActive = false;
                    Console.WriteLine("Take care!");
                }
            }

            Console.Clear();

            foreach (string wish in myWishList)
            {
                Console.WriteLine($"You wish: {wish}");
            }

            File.WriteAllLines($"{fileLocation}{fileName}", myWishList);
        }
    }
}
