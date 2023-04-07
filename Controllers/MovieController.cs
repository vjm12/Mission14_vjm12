using Microsoft.AspNetCore.Mvc;
using Mission14_vjm12.Controllers.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission14_vjm12.Controllers
{

    //API Controller to show data from database
    [ApiController]
    [Route("[controller]")]
    public class MovieController : Controller
    {
        private MovieDbContext context;
        public MovieController(MovieDbContext temp)
        {
            context = temp;
        }
        public IEnumerable<JoelsMovies> Get()
        {
            var x = context.Movies
                .Where(x=>x.Edited =="Yes")
                .OrderBy(x=>x.Title)
                .ToArray();
            return x;
        }
     
    }
}
