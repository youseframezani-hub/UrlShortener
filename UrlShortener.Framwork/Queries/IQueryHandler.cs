﻿namespace UrlShortener.Framwork.Queries
{
    public interface IQueryHandler<TQuery, TResult>
    where TQuery : IQuery
    {
        TResult Handle(TQuery query);
    }
}
