using System;
using System.Collections.Generic;
using System.Text;
using UrlShortener.Domain.UniqueCode;

namespace UrlShortener.Domain.UrlMap.Entities
{
    public class UrlMap
    {
        public UrlMap(UniquCodeGenerator uniquCodeGenerator, string url)
        {
            UniqueCode = uniquCodeGenerator.GetUniqueCode();
            Url = url;
        }

        public string UniqueCode { get; private set; }
        public string Url { get; private set; }

    }
}
