using System;

namespace LMS
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to our Library Management System");

            Book book = new();
            book.Title = "Harry Potter";
            book.Author = "J.K.R";
            book.ISBN = 123456789;
            book.TotalCopies = 100;
            book.AvailableCopies = 12;

            Book book2 = new();
            book2.Title = "Peter Pan";
            book2.Author = "James Mathew";
            book2.ISBN = 987654321;
            book2.TotalCopies = 50;
            book2.AvailableCopies = 5;

            Book book3 = new();
            book3.Title = "Money Honey";
            book3.Author = "Rachel Richards";
            book3.ISBN = 985254321;
            book3.TotalCopies = 20;
            book3.AvailableCopies = 0;

            Book book4 = new();
            book4.Title = "The Alchemist";
            book4.Author = "Paulo Coelho";
            book4.ISBN = 985254321;
            book4.TotalCopies = 20;
            book4.AvailableCopies = 0;

            Member member = new();
            member.Name = "Martin";
            member.MemberID = 12;
            Member membe2 = new();
            membe2.Name = "Iliq";
            membe2.MemberID = 13;

            Library library = new();
            library.AddBook(book);
            library.AddBook(book2);
            library.AddBook(book3);
            library.AddBook(book4);
            library.DisplayLibrary();

            library.RegisterMember(member);
            library.RegisterMember(membe2);

            member.BorrowBook(book);
            member.BorrowBook(book2);
            member.BorrowBook(book3);
            // Try to borrow more than the allowed limit (should display a message)
            member.BorrowBook(book4);

            member.ReturnBook();
            // Display the borrowed books after returning
            member.ReturnBook();







        }
    }
}