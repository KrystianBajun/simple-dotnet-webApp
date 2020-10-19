using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using webApp.Data;
using webApp.Models;

namespace webApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        private readonly webAppContext _context;

        public ValuesController (webAppContext context)
        {
            _context = context;

        }

        //
        // GET: api/values
        [HttpGet]
        public ActionResult<IEnumerable<Movie>> GetMovies()
        {
            return _context.Movie;
        }

    }
}
