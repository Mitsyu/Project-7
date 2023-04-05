namespace Project_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            Random rand = new Random();

            for (int i = 0; i < 25; i++)
            {
                numbers.Add(rand.Next(10, 21));
            }

            while (true)
            {
               
                Console.WriteLine("Here is the list of numbers:");
                Console.WriteLine($"[{string.Join(", ", numbers)}]");

                Console.WriteLine("Select an option:");
                Console.WriteLine("1 - Sort the list");
                Console.WriteLine("2 - Make a new list of random numbers");
                Console.WriteLine("3 - Remove a number (by value)");
                Console.WriteLine("4 - Add a value to the list");
                Console.WriteLine("5 - Count the number of occurrences of a specified number");
                Console.WriteLine("6 - Print the largest value");
                Console.WriteLine("7 - Print the smallest value");
                Console.WriteLine("8 - Quit");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        numbers.Sort();
                        break;
                    case 2:
                        for (int i = 0; i < 25; i++)
                        {
                            numbers.Add(rand.Next(10, 21));
                        }
                        break;
                    case 3:
                        Console.Write("Enter a number to remove: ");
                        int valueToRemove = int.Parse(Console.ReadLine());
                        numbers.RemoveAll(x => x == valueToRemove);
                        break;

                    case 4:

                        Console.Write("Enter a number to add: ");
                        int valueToAdd = int.Parse(Console.ReadLine());
                        numbers.Add(valueToAdd);
                        break;
                    case 5:
                        Console.Write("Enter a number to count: ");
                        int valueToCount = int.Parse(Console.ReadLine());
                        int count = numbers.Count(x => x == valueToCount);
                        Console.WriteLine($"The number {valueToCount} appears {count} times.");
                        break;
                    case 6:
                        Console.WriteLine($"The largest value is: {numbers.Max()}");
                        break;
                    case 7:
                        Console.WriteLine($"The smallest value is: {numbers.Min()}");
                        break;
                    case 8:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
    }
}