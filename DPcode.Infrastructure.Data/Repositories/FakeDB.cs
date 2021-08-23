using System.Collections.Generic;
using System;
using moviebrowsingconsoleapp.DPcode.Core.Model;
using moviebrowsingconsoleapp.DPcode.Infrastructure.Data.IRepositories;

namespace moviebrowsingconsoleapp.Infrastructure
{
    public class FakeDB : IFakeDB
    {
        private List<Movie> movies = new List<Movie>();

        public FakeDB(){
            for (int i = 0; i < 6; i++)
            {
                AddMovie(new Movie(i+1,100+i,("mov"+i)));
            }
        }
        public Movie AddMovie(Movie movie)
        {
            int id = movies.Count+1;
            Movie mov = new Movie(id,movie.year,movie.title); 
            movies.Add(mov);
            return movie;
        }

        public bool DeleteMovie(Movie movie)
        {
            foreach (Movie item in movies)
            {
                if(item.GetId()==movie.GetId()){
                    movies.Remove(item);
                    return true;
                    }
            }
            return false;
        }

        public List<Movie> GetAllMovies()
        {
            return movies;
        }

        public bool updateMovie(Movie movie)
        {
            Movie mov = movies[movie.GetId()];
            if(mov !=null) {
            mov.title=movie.title;
            mov.year=movie.year;
            }
            return mov !=null;
        }
    }
}