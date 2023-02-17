using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorsLibrary
{
    internal class Library : IEnumerable<Book>
    {
        private List<Book> books;

        public Library(List<Book> books)
        {
            this.books = new List<Book>(books);
        }

        public IEnumerator<Book> GetEnumerator()
        {
            for (int i = 0; i < books.Count; i++)
            {
                yield return books[i];

            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
