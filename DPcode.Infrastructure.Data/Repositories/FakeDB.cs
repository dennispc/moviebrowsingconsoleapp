using System.Collections.Generic;
using moviebrowsingconsoleapp.DPcode.Core.Model;
using moviebrowsingconsoleapp.DPcode.Infrastructure.Data.IRepositories;

namespace moviebrowsingconsoleapp.Infrastructure
{
    public class FakeDB : IFakeDB
    {
        public static List<Movie> movies = new List<Movie>();

        public FakeDB(){
            for(int i = 0 ; i < 5 ; i++)
            AddMovie(new Movie(120+i,("mov"+i)));
        }
        public Movie AddMovie(Movie movie)
        {
            int id = movies.Count+1;
            Movie mov = new Movie(id,movie.year,movie.title); 
            movies.Add(mov);
            return movie;
        }

        public bool deleteMovie(Movie movie)
        {
            movies.Remove(movie);
            return true;
        }

        public List<Movie> getAllMovies()
        {
            return movies;
        }

        public Movie getMovie(int id)
        {
            return movies[id];
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