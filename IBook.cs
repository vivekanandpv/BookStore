namespace BookStore {
    public interface IBook {
        string Title { get; }
        double Price { get; set; }
        int NPages { get; set; }
        BindType Bind { get; set; }

        void Describe(string text);
    }
}