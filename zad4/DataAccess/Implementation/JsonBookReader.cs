using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zad4.DataAccess.Interface;
using zad4.Models;

namespace zad4.DataAccess.Implementation
{
    class JsonBookReader : ISourceReader
    {
        public List<Book> ReadBooks(string path)
        {
            string books = File.ReadAllText(path);
            List<Book> BookList = JsonConvert.DeserializeObject<List<Book>>(books);
            return BookList;
        }
    }
}
