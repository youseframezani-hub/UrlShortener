using System;
using System.Collections.Generic;
using System.Text;
using UrlShortener.Framwork.Queries;

namespace UrlShortener.Domain.UrlMap.Queries
{
    public class RedirectUrlQuery:IQuery
    {
        public string UniqueCode { get; set; }
    }
}
