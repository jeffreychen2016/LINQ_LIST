using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_LIST
{
    class Program
    {
        static void Main(string[] args)
        {
            // Find the words in the collection that start with the letter 'L'
            List<string> fruits = new List<string>() { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };

            var LFruits = from fruit in fruits
                          where fruit[0] == 'L'
                          select fruit;

            foreach (var fruit in LFruits)
            {
                Console.WriteLine(fruit);
            }

            Console.WriteLine("------------------------------------------------------------");

            // Which of the following numbers are multiples of 4 or 6
            List<int> numbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            var fourSixMultiples = numbers.Where(number => number % 4 == 0 || number % 6 == 0);

            foreach (var number in fourSixMultiples)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("------------------------------------------------------------");

            // Order these student names alphabetically, in descending order (Z to A)
            List<string> names = new List<string>()
            {
                "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
                "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
                "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
                "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
                "Francisco", "Tre"
            };

            var descend = from name in names
                          orderby name descending
                          select name;

            foreach (var name in descend)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("------------------------------------------------------------");


            // Build a collection of these numbers sorted in ascending order
            List<int> numbers2 = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            var ascend = from number in numbers2
                         orderby number ascending
                         select number;

            foreach (var number in ascend)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("------------------------------------------------------------");

            // Output how many numbers are in this list
            List<int> numbers3 = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            var counts = (from number in numbers3
                          select number).Count();

            Console.WriteLine("Number Counts: " + counts);

            Console.WriteLine("------------------------------------------------------------");

            // How much money have we made?
            List<double> purchases = new List<double>()
            {
                2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
            };

            var revenue = (from purchase in purchases
                           select purchase).Sum();

            Console.WriteLine("Total Revenue: " + revenue);

            Console.WriteLine("------------------------------------------------------------");

            // What is our most expensive product?
            List<double> prices = new List<double>()
            {
                879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
            };

            var heighest = (from price in prices
                            select price).Max();

            Console.WriteLine("The Most Expensive: " + heighest);

            Console.WriteLine("------------------------------------------------------------");

            /*
                Store each number in the following List until a perfect square
                is detected.
            */
            List<int> wheresSquaredo = new List<int>()
            {
                66, 12, 8, 27, 82, 34, 7, 50, 19, 46, 81, 23, 30, 4, 68, 14
            };

            var perfectSquare = from number in wheresSquaredo
                                where Math.Sqrt(number) % 1 == 0
                                select number;

            foreach (var number in perfectSquare)
            {
                Console.WriteLine("Perfect Squares: " + number);
            }

            Console.WriteLine("------------------------------------------------------------");


        }
    }
}
