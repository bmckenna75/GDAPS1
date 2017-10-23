using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Book
    {
        private string title;
        private string author;
        private int totalPages;
        private string owner;
        private int timesRead;

        //get only properties
        public string Title
        {
            get { return title; }
        }
        public string Author
        {
            get { return author; }
        }
        public int TotalPages
        {
            get { return totalPages; }
        }


        //set && get properties
        public string Owner
        {
            get { return owner; }
            set
            {
                if (value != null && value.Trim().Length > 0)
                {
                    owner = value;
                }
            }
        }
        public int TimesRead
        {
            get { return timesRead; }
            set
            {
                if (value > timesRead)
                {
                    timesRead = value;
                }
            }
        }


        //constructor
        public Book(string t, string a, int total, string o)
        {
            title = t;
            author = a;
            totalPages = total;
            owner = o;
            timesRead = 0;
        }

        //methods
        public void Print()
        {
            Console.WriteLine("Title :" + title);
            Console.WriteLine("Author :" + author);
            Console.WriteLine("Total Number of Pages: " + totalPages);
            Console.WriteLine("Owner: " + owner);
            Console.WriteLine("Times Read: " + timesRead);
        }





    }
}
