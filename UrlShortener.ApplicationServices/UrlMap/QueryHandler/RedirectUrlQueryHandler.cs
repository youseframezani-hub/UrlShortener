using System;
using System.Collections.Generic;
using System.Text;
using UrlShortener.Domain.UrlMap.Queries;
using UrlShortener.Domain.UrlMap.Repositories;
using UrlShortener.Framwork.Queries;

namespace UrlShortener.ApplicationServices.UrlMap.QueryHandler
{

    public class RedirectUrlQueryHandler : IQueryHandler<RedirectUrlQuery, string>
    {
        private readonly IUrlMapRepository _urlMapRepository;

        public RedirectUrlQueryHandler(IUrlMapRepository urlMapRepository)
        {
            _urlMapRepository = urlMapRepository;
        }

        public string Handle(RedirectUrlQuery query)
        {
            var urlMap = _urlMapRepository.Find(query.UniqueCode);

            return urlMap.Url;
        }
    }
}
