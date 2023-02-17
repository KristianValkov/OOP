using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorsLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bookOne = new Book("Animal Farm", 2003, "George Orwell");
            var bookTwo = new Book("The Documents in the Case", 2002, "Dorothy Sayers");
            var bookThree = new Book("The Documents in the Case", 1930, "Stephen King");

            //var libraryOne = new Library();
            //var libraryTwo = new Library(bookOne, bookTwo, bookThree);
        }
    }
}
