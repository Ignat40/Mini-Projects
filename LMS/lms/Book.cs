using System.Runtime.CompilerServices;

namespace LMS
{
    /// <summary>
    /// #### `Book` Class:
    // - Properties: `Title`, `Author`, `ISBN` (a unique identifier for the book), `TotalCopies`, `AvailableCopies`.
    // - Methods: 
    // - `BorrowBook(Member member)`: Decreases the `AvailableCopies` by 1 if there are available copies.If not, display an appropriate message.
    // - `ReturnBook()`: Increases the `AvailableCopies` by 1.
    /// </summary>
    class Book
    {
        public string? Title;
        public string? Author;
        public int ISBN;
        public int TotalCopies;
        public int AvailableCopies;

        public int BorrowBook(Member member)
        {
            if (AvailableCopies >= 1)
            {
                AvailableCopies--;
                Array.Resize(ref member.BorrowedBooks, member.BorrowedBooks.Length + 1);
                TotalCopies--;
            }
            else
            {
                Console.WriteLine("Not enough books. Sorry you cannot borrow...");
            }

            return TotalCopies;
        }
        public int ReturnBook(Member member)
        {
            Array.Resize(ref member.BorrowedBooks, member.BorrowedBooks.Length - 1);
            AvailableCopies++;
            TotalCopies++;
            return TotalCopies;
        }
    }
}