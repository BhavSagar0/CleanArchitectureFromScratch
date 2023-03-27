using CleanMovie.Application.Services.Implementations;
using CleanMovie.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CleanMovie.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieService _service;

        public MoviesController(IMovieService movieService)
        {
            this._service = movieService;
        }
        [HttpGet]
        public ActionResult<List<Movie>> Get() 
        {
            var moviesFromService = _service.GetAllMovies();
            return Ok(moviesFromService);
        }

        [HttpPost]
        public ActionResult<Movie> PostMovie(Movie movie)
        {
            var Movie = _service.CreateMovie(movie);
            return Ok(Movie);
        }
    }
}
