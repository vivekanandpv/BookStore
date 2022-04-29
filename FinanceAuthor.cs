using System;

namespace BookStore {
    public class FinanceAuthor : IAuthor {
        private readonly string _fullName;

        public FinanceAuthor(string fullName) {
            _fullName = fullName;
        }

        public string Name => _fullName;

        public void Write(string text) {
            Console.WriteLine($"{_fullName} writes: {text}");
        }
    }
}
