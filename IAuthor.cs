using System.Collections.Generic;
using System.Text;

namespace BookStore {
    public interface IAuthor {
        string Name { get; }

        void Write(string text);
    }
}
