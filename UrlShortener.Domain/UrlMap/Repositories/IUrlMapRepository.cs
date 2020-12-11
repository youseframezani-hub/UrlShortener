namespace UrlShortener.Domain.UrlMap.Repositories
{
    public interface IUrlMapRepository
    {
        string Add(UrlMap.Entities.UrlMap urlMap);
        UrlMap.Entities.UrlMap Find(string code);
    }
}
