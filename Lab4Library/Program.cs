
namespace Lab4Library
{
    internal class Program
    {
        static void Main()
        {
            Library library = new Library();

            Book book1 = new Book(1, "Кобзар", "Тарас Шевченко");
            Book book2 = new Book(2, "Лісова пісня", "Леся Українка");
            Book book3 = new Book(3, "Колонія", "Макс Кідрук");
            Book book4 = new Book(4, "Колонія 2.0", "Макс Кідрук");
            Book book5 = new Book(5, "Солодка Даруся", "Марія Матіос");

            Reader reader1 = new Reader(1, "Федя");
            Reader reader2 = new Reader(2, "Аня");
            Reader reader3 = new Reader(3, "Вася");
            Reader reader4 = new Reader(4, "Маша");

            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);
            library.AddBook(book4);
            library.AddBook(book5);

            library.AddReader(reader1);
            library.AddReader(reader2);
            library.AddReader(reader3);
            library.AddReader(reader4);

            Console.WriteLine("===== УСІ КНИГИ =====");
            library.ShowAllBooks();

            Console.WriteLine("\n===== УСІ ЧИТАЧІ =====");
            library.ShowAllReaders();

            Console.WriteLine("\n===== ДОСТУПНІ КНИГИ =====");
            library.ShowAvailableBooks();

            Console.WriteLine("\n===== ВИДАЧА КНИГ =====");
            library.BorrowBook(1, 3); 
            library.BorrowBook(3, 5); 
            library.BorrowBook(2, 4); 

            Console.WriteLine("\n===== ПОВТОРНА ОРЕНДА =====");
            library.BorrowBook(4, 3); 

            Console.WriteLine("\n===== ОРЕНДОВАНІ КНИГИ =====");
            library.ShowBorrowedBooks();

            Console.WriteLine("\n===== ДОСТУПНІ КНИГИ ПІСЛЯ ВИДАЧІ =====");
            library.ShowAvailableBooks();

            Console.WriteLine("\n===== СПРОБА ПОВЕРНУТИ ЧУЖУ КНИГУ =====");
            library.ReturnBook(4, 3); 

            Console.WriteLine("\n===== ПОВЕРНЕННЯ КНИГИ =====");
            library.ReturnBook(1, 3); 

            Console.WriteLine("\n===== ДОСТУПНІ КНИГИ ПІСЛЯ ПОВЕРНЕННЯ =====");
            library.ShowAvailableBooks();

            Console.WriteLine("\n===== ПОВТОРНА ВИДАЧА ПІСЛЯ ПОВЕРНЕННЯ =====");
            library.BorrowBook(4, 3); 

            Console.WriteLine("\n===== ФІНАЛЬНИЙ СПИСОК ОРЕНДОВАНИХ КНИГ =====");
            library.ShowBorrowedBooks();

            Console.WriteLine("\n===== ФІНАЛЬНИЙ СПИСОК ЧИТАЧІВ =====");
            library.ShowAllReaders();
        }
    }
}

