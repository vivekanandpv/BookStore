using System;

namespace BookStore {
    internal class Program {
        static void Main(string[] args) {
            IBookFactory bookFactory = new DigestBookFactory();
           IBook book = bookFactory.CreateBook(BookType.Fiction);
            book.Describe("Message from client");
        }
    }
}
