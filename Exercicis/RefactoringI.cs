using System;
using System.Collections.Generic;

public class LibraryManagement
{
    public static void StartLibrary()
    {
        List<string> bookTitles = new List<string>();
        List<string> bookAuthors = new List<string>();
        List<int> bookYears = new List<int>();

        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Add book");
            Console.WriteLine("2. List books");
            Console.WriteLine("3. Find books by author");
            Console.WriteLine("4. Exit");
            string option = Console.ReadLine();

            if (option == "1")
            {
                Console.WriteLine("Enter title:");
                string title = Console.ReadLine();
                Console.WriteLine("Enter author:");
                string author = Console.ReadLine();
                Console.WriteLine("Enter year:");
                int year = int.Parse(Console.ReadLine());

                bookTitles.Add(title);
                bookAuthors.Add(author);
                bookYears.Add(year);

                Console.WriteLine("Book added.");
            }
            else if (option == "2")
            {
                for (int i = 0; i < bookTitles.Count; i++)
                {
                    Console.WriteLine((i + 1) + ". " + bookTitles[i] + " by " + bookAuthors[i] + " (" + bookYears[i] + ")");
                }
            }
            else if (option == "3")
            {
                Console.WriteLine("Enter author to search:");
                string searchAuthor = Console.ReadLine();
                for (int i = 0; i < bookAuthors.Count; i++)
                {
                    if (bookAuthors[i].ToLower().Contains(searchAuthor.ToLower()))
                    {
                        Console.WriteLine((i + 1) + ". " + bookTitles[i] + " by " + bookAuthors[i] + " (" + bookYears[i] + ")");
                    }
                }
            }
            else if (option == "4")
            {
                exit = true;
            }
            else
            {
                Console.WriteLine("Invalid option.");
            }

            Console.WriteLine();
        }

        Console.WriteLine("Exiting program...");
    }
}