namespace LMS
{
    /// <summary>
    /// #### `Member` Class:
    // - Properties: `Name`, `MemberId` (a unique identifier for the member), `BooksBorrowed` (a list of books the member has borrowed).
    // - Methods:
    // - `BorrowBook(Book book)`: Adds the book to the member's `BooksBorrowed` list if the member is allowed to borrow more books (limit to 5 books per member). If the member has already borrowed 5 books, display a message indicating the limit has been reached.
    // - `ReturnBook(Book book)`: Removes the book from the member's `BooksBorrowed` list.
    //     /// </summary>
    class Member
    {
        public string? Name; 
        public int MemberID;
        public string[] BorrowedBooks;

        public void BorrowBook(Book book)
        {
            if(BorrowedBooks.Length >= 5)
            {
                Console.WriteLine("You've reached the allowed amount of book you can borrow!");
            }
            else
            {
                for (int i = 0; i < BorrowedBooks.Length; i++)
                {
                    if(BorrowedBooks[i] == null)
                    {
                        BorrowedBooks[i] = book.Title;
                    } 
                }
            }
        }
        public void ReturnBook()
        {
            for (int i = 0; i < BorrowedBooks.Length; i++)
            {
                Console.WriteLine($"{i}. {BorrowedBooks[i]}");
            }
            Console.Write("Select which book you want to return: ");
            if(int.TryParse(Console.ReadLine(), out int usrChoice))
            {
                //finsh it later. 
            }

        }
    }
}