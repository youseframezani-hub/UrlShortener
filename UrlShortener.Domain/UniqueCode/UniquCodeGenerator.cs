using System.Collections.Generic;
using System.Text;

namespace UrlShortener.Domain.UniqueCode
{
    public interface UniquCodeGenerator
    {
        string GetUniqueCode();
    }
}
