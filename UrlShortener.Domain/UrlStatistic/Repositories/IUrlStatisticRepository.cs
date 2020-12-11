using System;
using System.Collections.Generic;
using System.Text;

namespace UrlShortener.Domain.UrlStatistic.Repositories
{
    public interface IUrlStatisticRepository
    {
        void Add(UrlStatistic.Entities.UrlStatistic urlStatistic);
        UrlStatistic.Entities.UrlStatistic Find(string urlMapUniqueCode);
        void Update(UrlStatistic.Entities.UrlStatistic urlStatistic);

    }
}
