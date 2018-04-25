﻿using System;
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
    class XmlBookReader : ISourceReader
    {
        static XmlSerializer serializer =
        new XmlSerializer(typeof(List<Book>), new XmlRootAttribute("BookList"));
        public List<Book> ReadBooks(string filePath)
        {
            using (var fileStream = File.OpenRead(filePath))
            {
                return (List<Book>)serializer.Deserialize(fileStream);
            }
        }
    }
}
