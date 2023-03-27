using CleanMovie.Application.Repositories;
using CleanMovie.Domain.Models;
using CleanMovie.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMovie.Infrastructure.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly MovieDbContext _dbContext;

        public MovieRepository(MovieDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Movie CreateMovie(Movie movie)
        {
            _dbContext.Movies.Add(movie);
            _dbContext.SaveChanges();

            return movie;
        }

        public List<Movie> GetAllMovies()
        {
            return _dbContext.Movies.ToList();
        }
    }
}
