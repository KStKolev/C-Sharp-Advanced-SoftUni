﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
        private List<Book> books;

        public Library(params Book[] books)
        {
            this.books = new List<Book>();
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryIterator(this.books);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public class LibraryIterator : IEnumerator<Book>
        {
            private readonly List<Book> books;
            private int currentIndex;
            public LibraryIterator(IEnumerable<Book> books) 
            {
                this.books = (List<Book>)books;
                this.Reset();
            }

            public void Dispose()
            {
                throw new NotImplementedException();
            }

            public bool MoveNext()
                => ++this.currentIndex < this.books.Count;

            public void Reset() => this.currentIndex = -1;

            public Book Current => this.books[this.currentIndex];

            object IEnumerator.Current => this.Current;
        }
    }
}
