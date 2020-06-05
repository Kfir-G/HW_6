using System;

namespace HW_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Book[] books = new Book[10];

        }
        public static int ReturnBook(Book book)
        {
            if(book is ComicBook)
            {
                ComicBook comicBook = book as ComicBook;
                if (comicBook.ReturnDate.CompareTo(DateTime.Now) > 0)//later 
                {
                    Console.WriteLine("The fine is: {0}", comicBook.Fine());
                    return -(comicBook.ReturnDate.Day);
                }
                else
                {
                    return (comicBook.ReturnDate.Day);
                }
            }
            if(book is CookBook)
            {
                CookBook cookBook = book as CookBook;
                if(cookBook.ReturnDate.CompareTo(DateTime.Now) > 0)//later
                {
                    Console.WriteLine("The Fine is:{0}", cookBook.Fine());
                    return -(cookBook.ReturnDate.Day);
                }
                else
                {
                    return (cookBook.ReturnDate.Day);
                }
            }
            return 0;   //default
        }
    }
}
