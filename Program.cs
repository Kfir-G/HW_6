using System;

namespace HW_6
{
    class Program
    {
        //-----Main----
        static void Main(string[] args)
        {
            Book[] books = new Book[10];
            /*books[0] = new ComicBook();
            books[1] = new ComicBook();
            books[2] = new ActionComicBook();
            books[3] = new ActionComicBook();
            books[4] = new CookBook();
            books[5] = new CookBook();
            books[6] = new CosherCookBook();
            books[7] = new CosherCookBook();*/

            DateTime dateTime = new DateTime(2020 , 06 , 10);
            books[0] = new ComicBook ( "jjj", 10, "ppp", dateTime);
            ReturnBook(books[0]);
        }

        //------functions------
        public static void ReturnBook(Book book)
        {
            if(book is ComicBook)
            {
                if ( ((ComicBook)book).Return() < 0)//later 
                    Console.WriteLine("You are late! in {0} days", ((ComicBook)book).Return());
                else
                    Console.WriteLine("You have {0} days too return", ((ComicBook)book).Return());
                return; //Exit
            }
            if (book is CookBook)
            {
                if (((CookBook)book).Return() < 0)//later 
                    Console.WriteLine("You are late! in {0} days", ((CookBook)book).Return());
                else
                    Console.WriteLine("You have {0} days too return", ((CookBook)book).Return());
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
            if(book is CookBook)
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
