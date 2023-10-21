using System;
using Microsoft.VisualBasic;

namespace BookSort
{

    enum BookGenre
    {
        Novel,
        Sci_Fi,
        Biography,
        Criminal
    }

    struct BookID
    {
        public string BookName;
        public string BookAuthor;
        public BookGenre Genre;
        public int YearOfIssue;
        public string Isbn;
    }
    class Program
    {

        static BookID[] library = new BookID[]
        {
            new BookID{BookName = "IT", BookAuthor = "Stephen King",
            Genre = BookGenre.Novel, YearOfIssue = 1986, Isbn = "1243987298123"},
            new BookID{BookName = "Harry Potter", BookAuthor = "J.K.Rowling",
            Genre = BookGenre.Sci_Fi, YearOfIssue = 1997, Isbn = "1234567898765"},
            new BookID{BookName = "Steve Job", BookAuthor = "Af Walter Isaacson",
            Genre = BookGenre.Biography, YearOfIssue = 2011, Isbn = "9876543212345"},
        };

        public static void Main()
        {
            /// <summary>
            /// You are tasked with building a simple library catalog system. You need to implement the following operations:
            // Add Book: Allow users to add books to the catalog. Each book has a title, author, and unique ISBN(International Standard Book Number).
            // Search Book: Allow users to search for books by their title, author, or ISBN.Display all matching books found in the catalog.
            // Remove Book: Allow users to remove a book from the catalog by providing its ISBN.
            // Implement a program that allows users to perform these operations in the library catalog system without using classes.
            // Requirements:
            // Use arrays or lists to store the books in the catalog.
            // Provide a menu - driven interface for users to choose different operations.
            // Implement input validation to ensure the user enters valid information.
            /// </summary>

            Console.WriteLine("Welcome to our Mini Library!\n");

            while (true)
            {
                Console.WriteLine("Choose one of the following options: ");
                Console.WriteLine("1. View Catalogue");
                Console.WriteLine("2. Add Book");
                Console.WriteLine("3. Search Book");
                Console.WriteLine("4. Remove Book");
                Console.WriteLine("5. Exit\n");

                Console.Write("Choice: ");
                string? userInput = Console.ReadLine();

                if (userInput == "1")
                {
                    ListBooks();
                }
                else if (userInput == "2")
                {
                    AddBook();
                }
                else if (userInput == "3")
                {
                    SearchBook();
                }
                else if (userInput == "4")
                {
                    RemoveBook();
                }
                else if (userInput == "5")
                {
                    Console.WriteLine("BYE!");
                    break;
                }
                else
                {
                    Console.WriteLine("\nInvalid Input. Please Try Again...\n");
                    continue;
                }

            }
        }

        public static void ListBooks()
        {
            for (int i = 0; i < library.Length; i++)
            {
                Console.WriteLine($"\n{i + 1}. {library[i].BookName}");
                Console.WriteLine($"       Author: {library[i].BookAuthor}");
                Console.WriteLine($"       Genre: {library[i].Genre}");
                Console.WriteLine($"       Year: {library[i].YearOfIssue}");
                Console.WriteLine($"       ISBN: {library[i].Isbn}");
            }
            Console.WriteLine("");
        }

        public static void AddBook()
        {
            Console.WriteLine("Enter Book Name: ");
            string? nameInput = Console.ReadLine();
            Console.WriteLine("Enter Author's Name: ");
            string? authorInput = Console.ReadLine();
            Console.WriteLine("Enter index for ganre \n[0-Novel, 1-Sci-Fi, 2-Biography, 3-Criminal]:");
            if (int.TryParse(Console.ReadLine(), out int genInput)
            && (genInput == 0 || genInput == 1 || genInput == 2 || genInput == 3))
            {
                BookGenre genreInput = (BookGenre)genInput;
                Console.WriteLine("Enter Year of Issue: ");
                if (int.TryParse(Console.ReadLine(), out int yearIn))
                {
                    int yearInput = yearIn;
                    Console.WriteLine("Enter ISNB number: ");
                    string? isnbInput = Console.ReadLine();

                    if (isnbInput.Length != 13)
                    {
                        Console.WriteLine("Not 13 Digits. Enter Again: \n");
                    }
                    else
                    {
                        Array.Resize(ref library, library.Length + 1);
                        library[^1] = new BookID
                        {
                            BookName = nameInput,
                            BookAuthor = authorInput,
                            Genre = genreInput,
                            YearOfIssue = yearInput,
                            Isbn = isnbInput
                        };

                        Console.WriteLine("\nBook Successfully Added!\n");
                    }


                }
                else
                {
                    Console.WriteLine("Invalid Index. Try again...");
                }
            }
            else
            {
                Console.WriteLine("Invalid Index. Try again...");
            }


        }
        public static void RemoveBook()
        {
            for (int i = 0; i < library.Length; i++)
            {
                Console.WriteLine($"{i} : {library[i].BookName}");
            }

            Console.WriteLine("Select index to be removed: ");
            if (int.TryParse(Console.ReadLine(), out int index)
            && index >= 0 && index <= library.Length)
            {
                for (int i = index; i < library.Length - 1; i++)
                {
                    library[i] = library[i + 1];
                }
                Array.Resize(ref library, library.Length - 1);

                Console.WriteLine("\n Book Successfully removed! \n");
            }
            else
            {
                Console.WriteLine("\nInvalid Index. Try again...\n");
            }

        }
        public static void SearchBook()
        {
            Console.WriteLine("Enter book name to see if available: ");
            string? input = Console.ReadLine().ToLower().Replace(" ", "");

            bool bookFound = false;

            for (int i = 0; i < library.Length; ++i)
            {
                string name = library[i].BookName.Replace(" ", "").ToLower();
                if (input == name)
                {
                    Console.WriteLine($"\nYour Book: {library[i].BookName}");
                    Console.WriteLine($"Author: {library[i].BookAuthor}");
                    Console.WriteLine($"Genre: {library[i].Genre}");
                    Console.WriteLine($"Year: {library[i].YearOfIssue}");
                    Console.WriteLine($"ISBN: {library[i].Isbn}\n");
                    bookFound = true;
                    break; 
                }
            }

            if (!bookFound)
            {
                Console.WriteLine("\nBook not found...\n");
            }

        }

    }
}
