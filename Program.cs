using System;
using System.Collections.Generic;

namespace Project_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choice = "";
            bool running = true;

            while (running)
            {
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine("Menu");
                Console.WriteLine("1. List of integers");
                Console.WriteLine("2. List of strings");
                Console.WriteLine();
                Console.WriteLine("Choose what program to run (1-2): ");
                choice = Console.ReadLine().ToLower().Trim();

                switch (choice)
                {

                    case "1":
                        ListOfIntegers();
                        break;

                    case "2":
                        ListOfStrings();
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid choice. Choose from (1-2)");
                        break;
                }
            }
        }
        private static void ListOfIntegers()
        {
            //Part 1
            Console.WriteLine("- List of integers program -");

            List<int> numbers = new List<int>();
            Random rand = new Random();

            for (int i = 0; i < 25; i++)
            {
                numbers.Add(rand.Next(10, 21));
            }

            string choice = "";

            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Here is your list of numbers:");
            Thread.Sleep(1000);
            Console.WriteLine($"[{string.Join(", ", numbers)}]");
            Thread.Sleep(500);

            while (true)
            {
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine("---------------------------------------------------------");
                Console.WriteLine();
                Console.WriteLine("Please select an option (1-10):");
                Console.WriteLine("1. Sort the list");
                Console.WriteLine("2. Make a new list of random numbers");
                Console.WriteLine("3. Remove a number");
                Console.WriteLine("4. Add a value to the list");
                Console.WriteLine("5. Count the number of occurrences of a specified number");
                Console.WriteLine("6. Print the largest value");
                Console.WriteLine("7. Print the smallest value");
                Console.WriteLine("8. Print the sum and average of the numbers");
                Console.WriteLine("9. Determine the most frequently occurring value(s)");
                Console.WriteLine("10. Quit");
                Console.WriteLine();
                Console.Write("Option: ");
                choice = Console.ReadLine().ToLower().Trim();
                Console.WriteLine();
                Console.WriteLine("---------------------------------------------------------");
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        numbers.Sort();
                        Console.WriteLine("Here is the sorted list:");
                        Console.WriteLine($"[{string.Join(", ", numbers)}]");
                        break;

                    case "2":
                        numbers.Clear();
                        for (int i = 0; i < 25; i++)
                        {
                            numbers.Add(rand.Next(10, 21));
                        }
                        Console.WriteLine("Here is the NEW list of numbers:");
                        Console.WriteLine($"[{string.Join(", ", numbers)}]");
                        break;

                    case "3":
                        Console.Write("Enter a number to remove: ");
                        int removeNumber;
                        if (!int.TryParse(Console.ReadLine(), out removeNumber))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid input. Please enter an integer");
                            continue;
                        }
                        numbers.RemoveAll(x => x == removeNumber);
                        Console.WriteLine();
                        Console.WriteLine($"Here is the list with the number {removeNumber} removed:");
                        Console.WriteLine();
                        Console.WriteLine($"[{string.Join(", ", numbers)}]");
                        break;

                    case "4":
                        Console.Write("Enter a number to add: ");
                        int addNumber;
                        if (!int.TryParse(Console.ReadLine(), out addNumber))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid input. Please enter an integer");
                            continue;
                        }
                        numbers.Add(addNumber);
                        Console.WriteLine($"Here is the list with the number {addNumber} added:");
                        Console.WriteLine();
                        Console.WriteLine($"[{string.Join(", ", numbers)}]");
                        break;

                    case "5":
                        Console.Write("Enter a number to count: ");
                        int countNumber;
                        Console.WriteLine();
                        if (!int.TryParse(Console.ReadLine(), out countNumber))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid input. Please enter an integer");
                            continue;
                        }
                        int count = numbers.Count(x => x == countNumber);
                        Console.WriteLine($"The number {countNumber} appears {count} times.");
                        Console.WriteLine();
                        Console.WriteLine("Here is your list of numbers again:");
                        Console.WriteLine();
                        Console.WriteLine($"[{string.Join(", ", numbers)}]");
                        break;

                    case "6":
                        Console.WriteLine($"The largest value is: {numbers.Max()}");
                        Console.WriteLine();
                        Console.WriteLine("Here is your list of numbers again:");
                        Console.WriteLine();
                        Console.WriteLine($"[{string.Join(", ", numbers)}]");
                        break;

                    case "7":
                        Console.WriteLine($"The smallest value is: {numbers.Min()}");
                        Console.WriteLine();
                        Console.WriteLine("Here is your list of numbers again:");
                        Console.WriteLine();
                        Console.WriteLine($"[{string.Join(", ", numbers)}]");
                        break;

                    case "8":
                        Console.WriteLine($"The sum of the numbers is, {numbers.Sum()} and the average is, {numbers.Average()}");
                        Console.WriteLine();
                        Console.WriteLine("Here is your list of numbers again:");
                        Console.WriteLine();
                        Console.WriteLine($"[{string.Join(", ", numbers)}]");
                        break;

                    case "9":
                        var groups = numbers.GroupBy(x => x).Select(g => new { Value = g.Key, Count = g.Count() });
                        int maxCount = groups.Max(g => g.Count);
                        var mostFrequent = groups.Where(g => g.Count == maxCount).Select(g => g.Value);
                        //internet solution
                        Console.Write("The most frequently occurring value(s) is: ");
                        foreach (var value in mostFrequent)
                        {
                            Console.WriteLine(value);
                        }
                        Console.WriteLine();
                        Console.WriteLine("Here is your list of numbers again:");
                        Console.WriteLine();
                        Console.WriteLine($"[{string.Join(", ", numbers)}]");
                        break;

                    case "10":
                        Environment.Exit(0);
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid option. Please enter a number from (1-10)");
                        break;
                }
            }
        }
        private static void ListOfStrings()
        {
            //Part 2 
            Console.WriteLine();
            Console.WriteLine("- List of strings program -");
            Console.WriteLine();

            string choice = "";
            List<string> vegetables = new List<string> { "CARROT", "BEET", "CELERY", "RADISH", "CABBAGE" };
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine();

            PrintVegetables(vegetables);

            while (true)
            {
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine("---------------------------------------------------------");
                Console.WriteLine();
                Console.WriteLine("Please select an option (0-6):");
                Console.WriteLine("1. Remove a vegetable by index");
                Console.WriteLine("2. Remove a vegetable by value");
                Console.WriteLine("3. Search for a vegetable");
                Console.WriteLine("4. Add a vegetable");
                Console.WriteLine("5. Sort list");
                Console.WriteLine("6. Clear the list");
                Console.WriteLine("7. Quit");
                Console.WriteLine();
                Console.Write("Option: ");
                choice = Console.ReadLine().ToLower().Trim();
                //int option = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("---------------------------------------------------------");
                Console.WriteLine();

                switch (choice)
                {
                    case "7":
                        Environment.Exit(0);
                        break;

                    case "1":
                        Console.Write("Please enter the index of the vegetable you wish to remove: ");
                        int indexToRemove = Convert.ToInt32(Console.ReadLine());
                        if (indexToRemove >= 0 && indexToRemove < vegetables.Count)
                        {
                            vegetables.RemoveAt(indexToRemove);
                            Console.WriteLine("Vegetable removed.");
                        }
                        else
                        {
                            Console.WriteLine("Invalid index.");
                        }
                        break;

                    case "2":
                        Console.Write("Please enter the name of the vegetable you wish to remove: ");
                        string valueToRemove = Console.ReadLine().ToUpper();
                        if (vegetables.Remove(valueToRemove))
                        {
                            Console.WriteLine($"Vegetable ({valueToRemove}) removed.");
                        }
                        else
                        {
                            Console.WriteLine("Vegetable not found.");
                        }
                        break;

                    case "3":
                        Console.Write("Please enter the name of the vegetable you wish to search for: ");
                        string valueToSearch = Console.ReadLine().ToUpper();
                        int index = vegetables.IndexOf(valueToSearch);
                        if (index >= 0)
                        {
                            Console.WriteLine($"Vegetable found at index {index}.");
                        }
                        else
                        {
                            Console.WriteLine("Vegetable not found.");
                        }
                        break;

                    case "4":
                        Console.Write("Please enter the name of the vegetable you wish to add: ");
                        string valueToAdd = Console.ReadLine().ToUpper();
                        if (vegetables.Contains(valueToAdd))
                        {
                            Console.WriteLine("Vegetable already in list.");
                        }
                        else
                        {
                            vegetables.Add(valueToAdd);
                            Console.WriteLine("Vegetable added.");
                        }
                        break;

                    case "5":
                        vegetables.Sort();
                        Console.WriteLine("List sorted.");
                        break;

                    case "6":
                        vegetables.Clear();
                        Console.WriteLine("List cleared.");
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid option. Please enter a number from (1-7)");
                        break;
                }

                PrintVegetables(vegetables);
            }
        }

        static void PrintVegetables(List<string> vegetables)
        {
            Console.ResetColor();
            Console.WriteLine("Vegetables");
            for (int i = 0; i < vegetables.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {vegetables[i]}");
            }
        }
    }

}
   


            