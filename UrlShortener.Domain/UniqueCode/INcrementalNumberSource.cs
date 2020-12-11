namespace UrlShortener.Domain.UniqueCode
{
    public interface INcrementalNumberSource
    {
        long GetTheLatestNewNumber();
    }
}
