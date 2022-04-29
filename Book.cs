using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore {
    public class Book : IBook {
        private string _title;
        private string _byline;
        
        private readonly IAuthor _author;

        public Book(IAuthor author) {
            _author = author;
        }

        public string Title { get => $"{_title}: {_byline}"; }
        public double Price { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int NPages { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public BindType Bind { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Describe(string text) {
            _author.Write(text);
        }
    }
}
