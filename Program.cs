using System;

namespace HW_6
{
    class Program
    {
        //-----Main----
        static void Main(string[] args)
        {
            //a:
            Book[] books = new Book[10];
            books[0] = new ComicBook();
            books[1] = new ComicBook();
            books[2] = new ActionComicBook();
            books[3] = new ActionComicBook();
            books[4] = new CookBook();
            books[5] = new CookBook();
            books[6] = new CosherCookBook();
            books[7] = new CosherCookBook();

            //d:
            DateTime dateTime1 = new DateTime(2020 , 01 , 1);
            books[0] = new ComicBook ("comicbook", 10, "ppp", dateTime1);
            DateTime dateTime2 = new DateTime(2021, 02, 2);
            books[2] = new ActionComicBook("actioncomicbook", 20, "jjj", dateTime2, 19);
            DateTime dateTime3 = new DateTime(2019, 03, 3);
            books[4] = new CookBook("cookbook", 40, "yyy", dateTime3, true);
            DateTime dateTime4 = new DateTime(2019, 04, 4);
            books[6] = new CosherCookBook("coshercookbook", 40, "yyy", dateTime4, true, "Pdo");

            //e:
            for (int i = 0; i < 10; i++)
                PrintBook(books[i]);

            Console.WriteLine("===================================================================================\n");

            //f:
            for (int i = 0; i < 10; i++)
                PrintSummarize(books[i]);

            //g:
            Array.Sort(books);
            for (int i = 0; i < 10; i++)
                PrintBook(books[i]);
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
                if ( ((CookBook)book).Return() < 0)//later 
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
                if ( ((ComicBook)book).Borrow(daysBorrow) )
                    Console.WriteLine("{0}" ,((ComicBook)book).ToString());
                else
                    Console.WriteLine("You can't Borrow the Book");
                return;//--Exit--
            }
            if(book is CookBook)
            {
                if ( ((CookBook)book).Borrow(daysBorrow) )
                    Console.WriteLine("{0}", ((CookBook)book).ToString());
                else
                    Console.WriteLine("You can't Borrow the Book");
                return;//--Exit--
            }
        }
        public static void PrintBook(Book book)
        {
            Console.WriteLine("\n");
            if(book is Book)
            {
                Console.WriteLine("{0}" ,book.ToString());
                return;//--Exit--
            }
            if(book is ComicBook)
            {
                Console.WriteLine("{0}", ((ComicBook)book).ToString());
                return;//--Exit--
            }
            if (book is ActionComicBook)
            {
                Console.WriteLine("{0}", ((ActionComicBook)book).ToString());
                return;//--Exit--
            }
            if (book is CookBook)
            {
                Console.WriteLine("{0}", ((CookBook)book).ToString());
                return;//--Exit--
            }
            if (book is CosherCookBook)
            {
                Console.WriteLine("{0}", ((CosherCookBook)book).ToString());
                return;//--Exit--
            }
        }
        public static void PrintSummarize(Book book)
        {
            Console.WriteLine("\n");
            if (book is Book)
            {
                Console.WriteLine("{0}", book.Summarize());
                return;//--Exit--
            }
            if (book is ComicBook)
            {
                Console.WriteLine("{0}", ((ComicBook)book).Summarize());
                return;//--Exit--
            }
            if (book is ActionComicBook)
            {
                Console.WriteLine("{0}", ((ActionComicBook)book).Summarize());
                return;//--Exit--
            }
            if (book is CookBook)
            {
                Console.WriteLine("{0}", ((CookBook)book).Summarize());
                return;//--Exit--
            }
            if (book is CosherCookBook)
            {
                Console.WriteLine("{0}", ((CosherCookBook)book).Summarize());
                return;//--Exit--
            }
        }
    }
}
