using System;
using System.Threading;

namespace temp_code
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Choose your Toast Adventure");
            Thread.Sleep(2000);
            Console.Clear();

            // STEP 1
            Console.WriteLine("You wake up to the smell of freshly baked bread. Your day is off to a great start! Do you:\n1. Make toast\n2. Make an omelet instead");
            string _choiceOne = Console.ReadLine() ?? "";

            if (_choiceOne == "1")
            {
                MakeToast();
            }
            else if (_choiceOne == "2")
            {
                MakeOmelet();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("That is not an option. Sorry, guess I'll choose for you.");
                Thread.Sleep(2000);
                Console.Clear();
                Console.WriteLine("You get toast");
                Thread.Sleep(2000);
                Console.Clear();
                MakeToast();
            }
        }

        static void MakeToast()
        {
            // STEP 2
            Console.Clear();
            Console.WriteLine("In the kitchen, you find two types of bread. Which one do you choose?\n1. White bread\n2. Whole grain bread");
            string _choiceTwo = Console.ReadLine() ?? "";

            if (_choiceTwo == "1")
            {
                // STEP 5
                Console.Clear();
                Console.WriteLine("You place a slice of white bread in the toaster, and wait.");
                Thread.Sleep(2000);
                Console.Clear();
                // animation Cooking...
                Cooking();

                // STEP 7
                Console.Clear();
                Console.WriteLine("It turns out great!"); 
                Console.WriteLine("Now it's time to choose a spread:\n1. Add butter\n2. Add orange marmalade");
                string _choiceFour = Console.ReadLine() ?? "";

                if (_choiceFour == "1")
                {
                    // STEP 9
                    Console.Clear();
                    Console.WriteLine("Your toast tastes boring because it is boring.");
                    Thread.Sleep(2000);
                    Console.Clear();
                    // END
                }
                else if (_choiceFour == "2")
                {
                    // STEP 10
                    Console.Clear();
                    Console.WriteLine("Orange you glad you chose marmalade?");
                    Thread.Sleep(2000);
                    Console.Clear();
                    // END
                }
                else
                {
                    Console.WriteLine("try again");
                    Thread.Sleep(2000);
                Console.Clear();
                    MakeToast();
                }
            }
            else if (_choiceTwo == "2")
            {
                // STEP 6
                Console.Clear();
                Console.WriteLine("You place a slice of whole grain bread in the toaster, and wait.");
                Thread.Sleep(2000);
                Console.Clear();
                // animation Cooking...
                Cooking();

                // STEP 8
                Console.Clear();
                Console.WriteLine("It's a little over toasted.");
                Thread.Sleep(2000);
                Console.Clear();
                Console.WriteLine("Shame, but now it's time to choose a spread:\n1. Add peanut butter\n2. Add raspberry jam");
                string _choiceFive = Console.ReadLine() ?? "";

                if (_choiceFive == "1")
                {
                    // STEP 11
                    Console.Clear();
                    Console.WriteLine("You should feel lucky! All the people who are gluten intolerant or allergic to peanuts are jealous of you.");
                    Thread.Sleep(2000);
                    Console.Clear();
                    // END
                }
                else if (_choiceFive == "2")
                {
                    // STEP 12
                    Console.Clear();
                    Console.WriteLine("Congratulations! This is just like how I make toast.");
                    Thread.Sleep(2000);
                    Console.Clear();
                    // END
                }
                else
                {
                    Console.WriteLine("try again");
                    Thread.Sleep(2000);
                    Console.Clear();
                    MakeToast();
                }
            }
            else
            {
                Console.WriteLine("try again");
                Thread.Sleep(2000);
                Console.Clear();
                MakeToast();
            }
        }

        static void MakeOmelet()
        {
            // STEP 3
            Console.Clear();
            Console.WriteLine("You prepare your ingredients and put them in a pan.");
            Thread.Sleep(2000);
            Console.Clear();
            
            // animation Cooking...
            Cooking();

            // STEP 4
            Console.WriteLine("Your omelet burns.");
            Thread.Sleep(2000);
            Console.Clear();

            Console.WriteLine("Do you:\n1. Make toast\n2. Make another omelet");
            string _choiceThree = Console.ReadLine() ?? "";

            if (_choiceThree == "1")
            {
                MakeToast();
            }
            else if (_choiceThree == "2")
            {
                MakeOmelet();
            }
            else
            {
                Console.WriteLine("try again");
                Thread.Sleep(2000);
                Console.Clear();
                MakeOmelet();
            }
        }

        static void Cooking()
        {
            int counter = 0;
            int totalIterations = 5;

            while (counter < totalIterations)
            {
                Console.Write("\b| Cooking");
                Thread.Sleep(200);
                Console.Clear();
                Console.Write("\b/ Cooking");
                Thread.Sleep(200);
                Console.Clear();
                Console.Write("\b- Cooking");
                Thread.Sleep(200);
                Console.Clear();
                Console.Write("\b\\ Cooking");
                Thread.Sleep(200);
                Console.Clear();

                counter++;
                if (counter % 4 == 0)
                {
                    Console.Write("\b| Cooking");
                    Console.Clear();
                }
            }
        }
    }
}