namespace LibrarySystemSln
{
    internal class Program

    {

        static Library library = new();

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            while (true)
            {
                try
                {
                    Console.WriteLine("\nLibrary Menu:");
                    Console.WriteLine("1. Add Item");
                    Console.WriteLine("2. Remove Item");
                    Console.WriteLine("3. Search Item");
                    Console.WriteLine("4. Display All Items");
                    Console.WriteLine("5. Exit");
                    Console.Write("Choose option: ");
                    string input = Console.ReadLine();

                    switch (input)
                    {
                        case "1":
                            Console.Write("Enter Item Type (Book, Magazine, DVD): ");
                            string type = Console.ReadLine();
                            var item = LibraryManager.CreateItem(type);
                            library.AddItem(item);
                            Console.WriteLine("Item added successfully.");
                            break;
                        case "2":
                            Console.Write("Enter ID to remove: ");
                            library.DeleteItem(Console.ReadLine());
                            Console.WriteLine("Item removed.");
                            break;
                        case "3":
                            Console.Write("Enter ID to search: ");
                            LibraryItem found = library.SearchItem(Console.ReadLine());
                            found.Display();
                            break;
                        case "4":
                            library.DisplayItems();
                            break;
                        case "5":
                            return;
                        default:
                            Console.WriteLine("Invalid input. Try again.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }
}

