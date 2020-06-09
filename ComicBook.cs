using System;
using System.Collections.Generic;
using System.Text;

namespace HW_6
{
    class ComicBook:Book, IBorrowable
    {
        //-----data fields----
        //protected string name
        //protected int pages      * if its negative->100
        //protected string author
        protected DateTime returnDate;

        //----properties----
        public DateTime ReturnDate { get => returnDate; set => returnDate = value; }

        //-----methods-----
            //constractors:
        public ComicBook():base()
        {
            ReturnDate = DateTime.Now; //default
        }
        public ComicBook(string name, int pages, string author, DateTime returnDate): base(name,pages,author)
        {
            ReturnDate = returnDate;
        }
            //
        public override string Summarize()
        {
            return "This comic book is for all ages to enjoy";
        }
        public override string ToString()
        {
            return base.ToString() + "\treturn date:" + returnDate;
        }
        
        //-----interface----
        public bool Borrow(int days) //for comic books ONLY!
        {
            DateTime dateTime = returnDate.AddDays(days);
            
            if (DateTime.Compare(returnDate, dateTime) < 0) //earlier
            {
                returnDate= returnDate.AddDays(days);
                return true;
            }
            else
                return false;
        }
        public int Return()
        {
            return returnDate.Subtract(DateTime.Now).Days;
        } 
    }

}
