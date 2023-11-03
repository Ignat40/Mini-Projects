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

        public int BorrowBook()
        {
            return TotalCopies;
        }
        public int ReturnBook()
        {
            return TotalCopies;
        }
    }
}