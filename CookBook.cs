using System;
using System.Collections.Generic;
using System.Text;

namespace HW_6
{
    class CookBook:Book
    {
        //protected string name
        //protected int pages;     * if its negative->100
        //protected string author
        private DateTime returnTime;
        protected bool isDamaged;

        //-----properties----
       
        public bool IsDamaged { get => isDamaged; set => isDamaged = value; }
        public DateTime ReturnTime { get => returnTime; set => returnTime = value; }

        //-----methods-----
            //constractors:
        public CookBook():base()
        {
            ReturnTime = DateTime.Now; //default
            IsDamaged = false;         //default
        }
        public CookBook (string name, int pages, string author, DateTime returnTime, bool isDamaged): base(name, pages, author)
        {
            ReturnTime = returnTime;
            IsDamaged = isDamaged;
        }
        //
        public override string Summarize()
        {
            return "This cooking book might contain non - kosher ingredients";
        }
        public override string ToString()
        {
            return base.ToString() + "\tdate:" + returnTime + "\t is it damaged:" + isDamaged;
        }
        public int Fine()
        {
            int bill = 0;
            if (isDamaged)
                bill += 100;
            //if איחור
            // כל יום איחור +10שח
            return bill;
        }
        //Borrow
        //Return
    }
}
