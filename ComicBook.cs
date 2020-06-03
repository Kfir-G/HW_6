using System;
using System.Collections.Generic;
using System.Text;

namespace HW_6
{
    class ComicBook:Book
    {
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
        public ComicBook( string name, int pages, string author, DateTime retrunDate): base(name,pages,author)
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
            return base.ToString() + "\tdate:" + returnDate;
        }
        //Borrow
        //Return 
    }
}
