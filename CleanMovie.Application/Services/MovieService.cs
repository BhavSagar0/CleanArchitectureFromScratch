﻿using CleanMovie.Application.Repositories;
using CleanMovie.Application.Services.Implementations;
using CleanMovie.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMovie.Application.Services
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;

        public MovieService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public Movie CreateMovie(Movie movie)
        {
            return _movieRepository.CreateMovie(movie);
        }

        public List<Movie> GetAllMovies()
        {
            var movies = _movieRepository.GetAllMovies();
            return movies;
        }
    }
}
