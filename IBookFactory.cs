﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore {
    public interface IBookFactory {
        IBook CreateBook(BookType bookType);
    }
}
