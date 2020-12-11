using System;
using System.Collections.Generic;
using System.Text;

namespace UrlShortener.Domain.UrlStatistic.Entities
{
    public class UrlStatistic
    {
        public UrlStatistic(string urlMapUniqueCode)
        {
            UrlMapUniqueCode = urlMapUniqueCode;
            this.TotalRedirect = 0;
            this.CreatedTime = DateTime.Now;
        }

        public string UrlMapUniqueCode { get; private set; }
        public int TotalRedirect { get; private set; }
        public DateTime CreatedTime { get; private set; }

        public void IncrementTotalRedirect()
        {
            this.TotalRedirect += 1;
        }
    }
}
