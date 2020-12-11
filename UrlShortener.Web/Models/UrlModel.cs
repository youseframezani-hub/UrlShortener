using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UrlShortener.Web.Models
{
    public class UrlModel
    {
        [Required(ErrorMessage = "Url Is Required")]
        public string Url { get; set; }
    }
}
