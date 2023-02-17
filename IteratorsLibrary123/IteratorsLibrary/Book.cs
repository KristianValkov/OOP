using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorsLibrary
{
    internal class Book
    {
        private string title;
        private int year;
        private List<string> author;

        public Book(string title, int year, List<string> author)
        {
            this.title = title;
            this.year = year;
            this.author = author;
        }

        public Book(string v1, int v2, string v3)
        {
        }

        public string Title
        {
            get { return this.title; }
            set { this.title = value; }
        }
        public int Year
        {
            get { return this.year; }
            set { this.year = value; }
        }
        public List<string> Author
        {
            get { return this.author; }
            set { this.author = value; }
        }
    }
}
