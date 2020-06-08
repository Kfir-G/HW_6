using System;

namespace HW_6
{
    class Program
    {
        //-----Main----
        static void Main(string[] args)
        {
            Book[] books = new Book[10];
            books[0] = new ComicBook(); 
        }

        //------functions------
        public static void ReturnBook(Book book)
        {
            if(book is ComicBook)
            {
                ComicBook comicBook = book as ComicBook;
                TimeSpan timeSpan = comicBook.ReturnDate.Subtract(DateTime.Now);
                if (timeSpan.Days > 0)//later 
                    Console.WriteLine("You are late! in {0} days", timeSpan.Days);
                else
                    Console.WriteLine("You have {0} days too return", timeSpan.Days);
                return; //Exit
            }
            if (book is CookBook)
            {
                CookBook cookBook = book as CookBook;
                if (cookBook.ReturnDate.CompareTo(DateTime.Now) > 0) //later
                    Console.WriteLine("The Fine is:{0}", cookBook.Fine());
                return; //Exit
            }
        }
        public static void BorrowBook(Book book, int daysBorrow)
        {
            if(book is ComicBook)
            {
                ComicBook comicBook = book as ComicBook; //maybe casting
                if (comicBook.Borrow(daysBorrow))
                    comicBook.ToString();
                else
                    Console.WriteLine("You can't Borrow the Book");
            }
            if( book is CookBook)
            {
                CookBook cookBook = book as CookBook;
                if (cookBook.Borrow(daysBorrow))
                    cookBook.ToString();
                else
                    Console.WriteLine("You can't Borrow the Book");
            }
        }
    }
}
