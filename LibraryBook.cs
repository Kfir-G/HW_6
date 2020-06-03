using System;
using System.Collections.Generic;
using System.Text;

namespace HW_6
{
    class LibraryBook : Book
    {
        //protected string name;
        //protected int pages;      * if its negative->100
        //protected string author;

        //-----properties----
        
        //-----methods-----
            //constractors:
        public LibraryBook():base()
        {

        }
        public LibraryBook(string name, int pages, string author): base(name ,pages ,author)
        {

        }
            //
        public override string Summarize()
        {
            return "This book is for reading inside the library only";
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
