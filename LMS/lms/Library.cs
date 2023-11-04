using System;
using System.Collections.Generic;

namespace LMS
{
    class Library
    {
        List<string> Books = new List<string>();
        List<string> LibraryMembers = new List<string>();

        public void DisplayLibrary()
        {
            foreach(var b in Books)
            {
                Console.WriteLine(b);
            }
        }
        public void DisplayMember(Member member)
        {
            foreach(var m in LibraryMembers)
            {
                Console.WriteLine($"Name: {member.Name} ID: {member.MemberID}");
            }
        }

        public void AddBook(Book book)
        {
            Books.Add(book.Title);
        }
        public void RemoveBook(Book book)
        {
            foreach(var el in Books)
            {
                Console.WriteLine(el);
            }
            Console.WriteLine("Enter the title of the book you want ro remove: ");
            string? userInputRemove = Console.ReadLine();
            Books.Remove(userInputRemove);
        }
        public void RegisterMember(Member member)
        {
            LibraryMembers.Add(member.Name);
        }
        public void UnregisterMember(Member member)
        {
             foreach(var mem in LibraryMembers)
            {
                Console.WriteLine(mem);
            }
            Console.WriteLine("Enter the name of the person you want ro remove: ");
            string? removeMember = Console.ReadLine();
            Books.Remove(removeMember);
        }
    }
}