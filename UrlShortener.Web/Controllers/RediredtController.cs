using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using UrlShortener.Domain.UrlMap.Queries;
using UrlShortener.Domain.UrlStatistic.Commands;
using UrlShortener.Framework.Commands;
using UrlShortener.Framwork.Queries;
using UrlShortener.Web.Models;

namespace UrlShortener.Web.Controllers
{
    [Route("/")]
    public class RediredtController : Controller
    {

        protected readonly CommandDispatcher _commandDispatcher;
        protected readonly QueryDispatcher _queryDispatcher;

        public RediredtController(CommandDispatcher commandDispatcher, QueryDispatcher queryDispatcher)
        {
            _commandDispatcher = commandDispatcher;
            _queryDispatcher = queryDispatcher;
        }

        [Route("/{code}")]
        public IActionResult Index(string code)
        {
           var url = _queryDispatcher.Dispatch<string>(new RedirectUrlQuery() { UniqueCode = code });
            if (string.IsNullOrEmpty(url))
            {
                return NotFound();
            }

            _commandDispatcher.Dispatch(new IncreaseTotalRedirectCommand() {UniqueCode = code });

            return Redirect(url);
        }


    }

}
