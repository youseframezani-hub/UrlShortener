using System;
using System.Collections.Generic;
using System.Text;
using UrlShortener.Domain.UrlStatistic.Repositories;

namespace UrlShortener.DataLayer.UrlStatistic
{
    public class SqlUrlStatisticRepository : IUrlStatisticRepository
    {
        public void Add(Domain.UrlStatistic.Entities.UrlStatistic urlStatistic)
        {
            throw new NotImplementedException();
        }

        public Domain.UrlStatistic.Entities.UrlStatistic Find(string urlMapUniqueCode)
        {
            throw new NotImplementedException();
        }

        public void Update(Domain.UrlStatistic.Entities.UrlStatistic urlStatistic)
        {
            throw new NotImplementedException();
        }
    }
}
