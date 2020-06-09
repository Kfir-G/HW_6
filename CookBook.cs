using System;
using System.Collections.Generic;
using System.Text;

namespace HW_6
{
    class CookBook:Book,IBorrowable
    {
        //-----data fields----
        //protected string name
        //protected int pages;     * if its negative->100
        //protected string author
        protected DateTime returnDate;
        protected bool isDamaged;

        //-----properties----
       
        public bool IsDamaged { get => isDamaged; set => isDamaged = value; }
        public DateTime ReturnDate { get => returnDate; set => returnDate = value; }

        //-----methods-----
            //constractors:
        public CookBook():base()
        {
            ReturnDate = DateTime.Now; //default
            IsDamaged = false;         //default
        }
        public CookBook (string name, int pages, string author, DateTime returnTime, bool isDamaged): base(name, pages, author)
        {
            ReturnDate = returnTime;
            IsDamaged = isDamaged;
        }
            //
        public override string Summarize()
        {
            return "This cooking book might contain non - kosher ingredients";
        }
        public override string ToString()
        {
            return base.ToString() + "\treturn date:" + returnDate + "\t is it damaged:" + isDamaged;
        }
        public int Fine()
        {
            TimeSpan resultDays = returnDate.Subtract(DateTime.Now); 
             int bill = 0;
             if (isDamaged)
                 bill += 100;
             if (resultDays.Days > 0)
                  bill += 10 * resultDays.Days;
            return bill;
        }

        //------interface------
        public bool Borrow(int days) //for comic books ONLY!
        {
            if ( returnDate.CompareTo(returnDate.Day + days) < 0)
            {
                //returnDate.AddDays(days);
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
