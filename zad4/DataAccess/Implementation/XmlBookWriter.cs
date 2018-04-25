using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using zad4.DataAccess.Interface;
using zad4.Models;

namespace zad4.DataAccess.Implementation
{
    class XmlBookWriter : ISourceWriter
    {

        
        public void WriteBooks(string filePath, List<Book> books)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Book>), new XmlRootAttribute("BookList"));

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                serializer.Serialize(writer, books);
            }
        }
    }
}
