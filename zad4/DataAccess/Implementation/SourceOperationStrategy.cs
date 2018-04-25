using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zad4.DataAccess.Interface;

namespace zad4.DataAccess.Implementation
{
    public class SourceOperationStrategy : ISourceOperationStrategy
    {
        private static readonly Dictionary<string, ISourceReader> _readers;

        private static readonly Dictionary<string, ISourceWriter> _writers;



        //getwriter
        public ISourceWriter GetWriter(string fileName)
        {

            var extension = Path.GetExtension(fileName);
            ISourceWriter writer = null;
            if (_writers.TryGetValue(extension, out writer))
            {
                return writer;
            }
            else
            {
                return null;
            }
        }
        


        static SourceOperationStrategy()
        {
            _readers = new Dictionary<string, ISourceReader>();
            _readers.Add(".xml", new XmlBookReader());
            _readers.Add(".json", new JsonBookReader());
            _writers = new Dictionary<string, ISourceWriter>();
            _writers.Add(".json", new JsonBookWriter());
            _writers.Add(".xml", new XmlBookWriter());
        }
        public ISourceReader GetReader(string fileName)
        {
            ISourceReader reader = null;
            var extension = Path.GetExtension(fileName);
            if (_readers.TryGetValue(extension, out reader))
            {
                return reader;
            }
            else
            {
                return null;
            }
            }

    }
}
