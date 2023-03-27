using CleanMovie.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMovie.Application.Repositories
{
    public interface IMovieRepository
    {
        List<Movie> GetAllMovies();
        Movie CreateMovie(Movie movie);
    }
}
