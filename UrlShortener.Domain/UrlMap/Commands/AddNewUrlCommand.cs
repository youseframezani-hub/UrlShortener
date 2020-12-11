using System.Collections.Generic;
using System.Text;
using UrlShortener.Framework.Commands;

namespace UrlShortener.Domain.UrlMap.Commands
{
    public class AddNewUrlCommand: ICommand
    {
        public string Url { get; set; }
    }
}
