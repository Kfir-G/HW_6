using System;
using System.Collections.Generic;
using System.Text;

namespace HW_6
{
    class ActionComicBook:ComicBook
    {
        //protected string name
        //protected int pages      * if its negative->100
        //protected string author
        //protected DateTime returnDate
        protected int minAge;       // if its negative ->16

        //-----properties-----
        public int MinAge { get => minAge; set => minAge = value; }

        //----methods---
            //constractors:
        public ActionComicBook(): base()
        {

        }
        public ActionComicBook(string name, int pages, string author, DateTime retrunDate, int minAge):base(name,pages,author,retrunDate)
        {
            MinAge = minAge;
        }
            //
        public override string Summarize()
        {
            return base.Summarize() + "\tThis action comic book is for ages greater than " + MinAge + " years old";
        }
        public override string ToString()
        {
            return base.ToString() + "\tthe minimal age is:" + minAge;
        }
        //Borrow
        //Return
    }
}
