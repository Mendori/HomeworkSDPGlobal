using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using zad4.DataAccess.Interface;
using zad4.Models;

namespace zad4.DataAccess.Implementation
{
    class JsonBookWriter : ISourceWriter
    {
        public void WriteBooks(string filePath, List<Book> books)
        {
            JsonSerializer serializer = new JsonSerializer();
            using (StreamWriter file = File.CreateText(filePath))
            {
                serializer.Formatting = Formatting.Indented;
                serializer.Serialize(file, books);
            }



            // serialize JSON to a string and then write string to a file
            //File.WriteAllText(filePath, JsonConvert.SerializeObject(books));


        }
    }

}
   
