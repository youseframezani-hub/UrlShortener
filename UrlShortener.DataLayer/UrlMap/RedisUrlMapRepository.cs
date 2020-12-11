using System;
using System.Collections.Generic;
using System.Text;
using UrlShortener.Domain.UrlMap.Repositories;

namespace UrlShortener.DataLayer.UrlMap
{
    public class RedisUrlMapRepository : IUrlMapRepository
    {
        public string Add(Domain.UrlMap.Entities.UrlMap urlMap)
        {
            throw new NotImplementedException();
        }

        public Domain.UrlMap.Entities.UrlMap Find(string code)
        {
            throw new NotImplementedException();
        }
    }
}
