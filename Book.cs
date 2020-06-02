using System;
using System.Collections.Generic;
using System.Text;

namespace HW_6
{
    abstract class Book
    {
        //-----data fields-----
        private string name;
        private int pages;      // if its negative->100
        private string author;  

        //-----properties----
        public string Name { get => name; set => name = value; }
        public int Pages { get => pages; set => pages = value; }
        public string Author { get => author; set => author = value; }

        //-----methods----
        public abstract string Summarize();
        public override string ToString()
        {
            return "The name of the book:" + name + "\t" + "number of pages:" + pages + "\t" + "the name of the author" + author;
        }
    }
}
