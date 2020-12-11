using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UrlShortener.Domain.UrlMap.Commands;
using UrlShortener.Framework.Commands;
using UrlShortener.Web.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UrlShortener.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UrlController : ControllerBase
    {


        protected readonly CommandDispatcher _commandDispatcher;

        public UrlController(CommandDispatcher commandDispatcher)
        {
            _commandDispatcher = commandDispatcher;
        }

        // POST api/<LinkController>
        [HttpPost("Add")]
        public IActionResult Add([FromBody] UrlModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = _commandDispatcher.Dispatch(new AddNewUrlCommand() { Url = model.Url });
            if (!result.IsSuccess)
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("", item);
                }
                return BadRequest(ModelState);
            }

            return Ok(new { url = result.DataResult });
        }

    }

}
