﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zad4.Models;

namespace zad4.DataAccess.Interface
{
    public interface ISourceWriter
    {
        void WriteBooks(string filePath, List<Book> books);
    }
}
