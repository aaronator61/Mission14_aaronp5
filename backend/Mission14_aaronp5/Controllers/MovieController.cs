using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mission14_aaronp5.Models;
using System.Collections.Generic;

namespace Mission14_aaronp5.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MovieController : Controller
    {
        private JoelHiltonMovieCollectionContext context;
        public MovieController(JoelHiltonMovieCollectionContext temp)
        {
            context = temp;
        }
        public IEnumerable<Movie> Get()
        {
            var x = context.Movies
                .Where(p => p.Edited == "Yes")
                .OrderBy(p => p.Title)
                .ToArray();
            return x;
        }
    }

    
}
