using System.Collections.Concurrent;

namespace Lab4Library
{
    internal class Reader
    {
        private List<Book> borrowedBooks = new List<Book>();
        public int ID { get; private set; }
        public string Name { get; private set; }

        public Reader(int id, string name)
        {
            ID = id;
            Name = name;
        }
        public void AddBook(Book book)
        {
            borrowedBooks.Add(book);
        }
        public bool RemoveBook(Book book)
        {
            if (borrowedBooks.Contains(book))
            {
                borrowedBooks.Remove(book);
                return true;
            }
            else
            {
                Console.WriteLine("Книга не була орендована");
                return false;
            }
        }
        public bool HasBook(Book book) => borrowedBooks.Contains(book);

        public void ShowBorrowedBooks()
        {
            foreach( Book borrowedBook in borrowedBooks)
            {
                Console.WriteLine($"ID:{borrowedBook.ID}, {borrowedBook.Title}, {borrowedBook.Author}");
            }
        }
    }
}