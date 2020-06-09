using System;
using System.Collections.Generic;
using System.Text;

namespace HW_6
{
    public interface IBorrowable
    {
        bool Borrow(int days);
        int Return();
    }
    abstract class Book: IComparable
    {
        //-----data fields-----
        protected string name;
        protected int pages;      // if its negative->100
        protected string author;  

        //-----properties----
        public string Name { get => name; set => name = value; }
        public int Pages { get => pages; set => pages = value; }
        public string Author { get => author; set => author = value; }

        //-----methods----
            //constructors:
        public Book() 
        {
            Name = "No name yet";               //default
            Pages = 100;                         //default
            Author = "No author's name yet";    //default
        }
        public Book(string name, int pages, string author)
        {
            Name = name;
            if (pages < 0)
                Pages = 100; //default
            else
                Pages = pages;
            Author = author;
        }
            //
        public abstract string Summarize();
        public override string ToString()
        {
            return "The name of the book:" + name + "\t" + "number of pages:" + pages + "\t" + "the name of the author:" + author;
        }

        //-----interface---
        public int CompareTo(object obj)
        {
            if ( !(obj is Book) )
                throw new Exception("this is not a vegtable");
            int result = String.Compare( ((Book)obj).name, name);
            if (result < 0) // name > book.Name
                return 1;
            if (result > 0) //name < book.Name
                return -1;
            return 0;//name == book.Name
        }
        
    }
}
