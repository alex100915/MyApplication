﻿using System.Collections.Generic;
using MyApplication.Core.Models;

namespace MyApplication.Core.Repositories
{
    public interface IMovieRepository
    {
        IEnumerable<Movie> GetAllMovies();
        Movie GetMovieById(int id);
        void Remove(Movie movie);
        void Add(Movie movie);
    }
}