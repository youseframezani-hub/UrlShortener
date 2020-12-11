using System;

namespace UrlShortener.Domain.UniqueCode
{
    public class RandomeUniquCodeGenerator : UniquCodeGenerator
    {
        public string GetUniqueCode()
        {
            byte[] bytes = Guid.NewGuid().ToByteArray();
            string base64String = Convert.ToBase64String(bytes).Trim('=');
            return base64String;
        }
    }
}
