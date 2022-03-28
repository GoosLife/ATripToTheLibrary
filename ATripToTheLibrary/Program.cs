using System;

namespace ATripToTheLibrary
{
    public class Program
    {
        static BookGenerator bg = new BookGenerator();
        public static void Main(string[] args)
        {
            // Beautify console
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Blue;

            Console.Clear();
            
            List<Book> books = bg.GenerateBooks(); // Generate list of books (with random genres/page count)
            Stack<Book> booksToBorrow = new Stack<Book>(); // Contains the books the user will borrow.

            string input;

            do
            {
                Console.WriteLine("  Enter the ID of the book you want to borrow: \n");

                for (int i = 0; i < books.Count; i++) // Print list of all books that can be borrowed
                {
                    Console.WriteLine(books[i] + "\n");
                }

                Console.WriteLine("\n\n  Type X to check out.");

                input = Console.ReadLine(); // Read userinput

                int choice; // Stores users choice, if users choice can be parsed as an integer.
                if (int.TryParse(input, out choice))
                {
                    try // Try finding book with the ID from users input, push it to the stack and remove it from the list.
                    {
                        Book b = books.Find(b => b.ID == choice);

                        booksToBorrow.Push(b);
                        books.Remove(b);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Something went wrong. Try again.");
                        Console.WriteLine("Error: " + ex.ToString());
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadKey();
                    }
                }

                Console.Clear();
            }
            while (books.Count > 0 && input != "X"); // Runs until user presses X or we run out of books to loan them.

            // Check out books when user inputs X
            if (input.ToUpper() == "X")
            {
                while (booksToBorrow.Count > 0) // As long as books are left in the stack
                {
                    Console.WriteLine("Checking out the following book: \n");
                    Console.WriteLine(booksToBorrow.Peek()); // Print the next book to check out
                    Console.WriteLine("\nBook has been checked out. Books left in stack: " + booksToBorrow.Count + "\n");
                    booksToBorrow.Pop(); // Book is checked out and thus removed from stack
                }
            }

            // It is safe to exit
            Console.WriteLine("All books have checked out, press any key to exit.");
            Console.ReadKey();
        }
    }
}