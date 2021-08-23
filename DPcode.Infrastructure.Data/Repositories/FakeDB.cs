using System.Collections.Generic;
using moviebrowsingconsoleapp.IInfrastructure;

namespace moviebrowsingconsoleapp.Infrastructure
{
    public class FakeDB : IFakeDB
    {
        public static List<Movie> movies = new List<Movie>();
        public Movie addMovie(Movie movie)
        {
            int id = movies.Count+1;
            Movie mov = new Movie(id,movie.year,movie.title); 
            movies.Add(mov);
            return movie;
        }

        public bool deleteMovie()
        {
            throw new System.NotImplementedException();
        }

        public List<Movie> getAllMovies()
        {
            throw new System.NotImplementedException();
        }

        public Movie getMovie()
        {
            throw new System.NotImplementedException();
        }

        public bool updateMovie(Movie movie)
        {
            throw new System.NotImplementedException();
        }
    }
}