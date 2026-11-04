using System.Collections.Concurrent;

namespace Lab4Library
{
    internal class Library
    {
        private List<Book> books = new List<Book>();
        private List<Reader> readers = new List<Reader>();

        public void AddBook(Book book)
        {
            if (books.Any(b => b.ID == book.ID))
            {
                Console.WriteLine("Книга з таким ID вже існує");
                return;
            } else {
                books.Add(book);
            }
        }
        public void AddReader(Reader reader)
        {
            if (readers.Any(r => r.ID == reader.ID))
            {
                Console.WriteLine("Читач з таким ID вже існує");
                return;
            }
            else
            {
                readers.Add(reader);
            }
        }
        public Book? FindBookById(int id)
        {
            Book? foundBook = books.Find(b => b.ID == id);
            return foundBook;
        }
        public Reader? FindReaderById(int id)
        {
            Reader? foundReader = readers.Find(r => r.ID == id);
            return foundReader;
        }
        public void BorrowBook(int readerId, int bookId)
        {
            Reader? reader = FindReaderById(readerId);
            if (reader == null)
            {
                Console.WriteLine("Читача не знайдено");
                return;
            }
            Book? book = FindBookById(bookId);
            if (book == null)
            {
                Console.WriteLine("Книги не знайдено");
                return;
            }

            bool success = book.Borrow();
            if (!success)
            {
                Console.WriteLine("Книга вже орендована");
                return;
            }
            reader.AddBook(book);
            Console.WriteLine($"Видана книжка {book.Title}, яку написав {book.Author}. Для {reader.Name}");
        }
        public void ReturnBook(int readerId, int bookId)
        {
            Reader? reader = FindReaderById(readerId);
            if (reader == null)
            {
                Console.WriteLine("Читача не знайдено");
                return;
            }
            Book? book = FindBookById(bookId);
            if (book == null)
            {
                Console.WriteLine("Книги не знайдено");
                return;
            }
            if (!reader.HasBook(book))
            {
                Console.WriteLine("Цей читач не орендував цю книгу");
                return;
            }

            bool success = book.ReturnBook();
            if (!success)
            {
                Console.WriteLine("Не вдалося повернути книгу");
                return;
            }
            reader.RemoveBook(book);
            Console.WriteLine($"Користува {reader.Name} повернув {book.Title} до бібліотеки");
        }

        public void ShowAllBooks()
        {
            foreach (Book book in books)
            {
                Console.WriteLine($"ID:{book.ID}, {book.Title}, {book.Author}");
            }
        }

        public void ShowAvailableBooks()
        {
            foreach (Book book in books)
            {
                if (book.IsAvailable)
                {
                    Console.WriteLine($"ID:{book.ID}, {book.Title}, {book.Author}");
                }
            }
        }
        public void ShowBorrowedBooks()
        {
            foreach (Book book in books)
            {
                if (!book.IsAvailable)
                {
                    Console.WriteLine($"ID:{book.ID}, {book.Title}, {book.Author}");
                }
            }
        }
        public void ShowAllReaders()
        {
           foreach(Reader reader in readers)
            {
                Console.WriteLine($"ID:{reader.ID}, {reader.Name}");
                reader.ShowBorrowedBooks(); 
            }
        }
    }
}