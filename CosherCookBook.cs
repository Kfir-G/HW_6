using System;
using System.Collections.Generic;
using System.Text;

namespace HW_6
{
    class CosherCookBook:CookBook
    {
        //-----data fields----
        //protected string name
        //protected int pages;     * if its negative->100
        //protected string author
        //protected DateTime returnTime;
        // protected bool isDamaged;
        protected string supervision;

        //----propeties-----
        public string Supervision { get => supervision; set => supervision = value; }

        //-----methods----
            //constrators:
        public CosherCookBook():base()
        {
            Supervision = "Not named yet";      //default
        }
        public CosherCookBook(string name, int pages, string author, DateTime returnTime, bool isDamaged, string supervision): base(name, pages, author, returnTime, isDamaged)
        {
            Supervision = supervision;
        }
            //
        public override string Summarize()
        {
            return "This kosher cooking book is supervised by" + supervision;
        }
        public override string ToString()
        {
            return base.ToString() + "\tsupervision" + supervision;
        }
        public new int Fine()
        {
            int bill = 0;
            if (isDamaged)
                bill += 200;
            // if איחור
            // 12שח+ על כל יום איחור
            return bill;
        }
        //Borrow
        //Return
    }
}
