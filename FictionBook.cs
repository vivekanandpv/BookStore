namespace BookStore {
    public class FictionBook : IBook {
        public string Title => throw new System.NotImplementedException();

        public double Price { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public int NPages { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public BindType Bind { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public void Describe(string text) {
            System.Console.WriteLine($"Not yet: {text}");
        }
    }
}