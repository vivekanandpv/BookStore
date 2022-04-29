namespace BookStore {
    public class DigestBookFactory : IBookFactory {
        public IBook CreateBook(BookType bookType) {
            switch (bookType) {
                case BookType.Fiction:
                    return new FictionBook();
                case BookType.NonFiction:
                case BookType.Science:
                case BookType.CurrentAffairs:
                default:
                    return new Book(new FinanceAuthor("Ajay Kumar"));
            }
            
        }
    }
}
