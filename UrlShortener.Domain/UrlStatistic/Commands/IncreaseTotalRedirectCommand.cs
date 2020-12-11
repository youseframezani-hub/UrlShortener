using System;
using System.Collections.Generic;
using System.Text;
using UrlShortener.Framework.Commands;

namespace UrlShortener.Domain.UrlStatistic.Commands
{
    public class IncreaseTotalRedirectCommand : ICommand
    {
        public string UniqueCode { get;  set; }
    }
}
