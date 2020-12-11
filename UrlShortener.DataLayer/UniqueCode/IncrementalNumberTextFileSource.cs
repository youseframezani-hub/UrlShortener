using System;
using System.Collections.Generic;
using System.Text;
using UrlShortener.Domain.UniqueCode;

namespace UrlShortener.DataLayer.UniqueCode
{
    public class IncrementalNumberTextFileSource : INcrementalNumberSource
    {
        private readonly string _filePath;

        public IncrementalNumberTextFileSource(string filePath)
        {
            _filePath = filePath;
        }

        public long GetTheLatestNewNumber()
        {
            throw new NotImplementedException();
        }
    }
}
