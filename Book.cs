using System;
using System.Collections.Generic;
using System.Text;

namespace HW_6
{
    class Book
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
    }
}
