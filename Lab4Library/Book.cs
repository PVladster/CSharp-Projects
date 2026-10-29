namespace Lab4Library
{
    internal class Book
    {
        public int ID { get; private set; }
        public string Title { get; private set; }
        public string Author { get; private set; }
        public bool IsAvailable { get; private set; }

        public Book(int id, string title, string author)
        {
            ID = id;
            Title = title;
            Author = author;
            IsAvailable = true;

        }

        public bool Borrow()
        {
            if (!IsAvailable == true)
            {
                return false;
            }
            IsAvailable = false;
            return true;
        }
        public bool ReturnBook()
        {
            if (IsAvailable == true)
            {
                return false;
            }
            IsAvailable = true;
            return true;
        }
        }
    }

    
