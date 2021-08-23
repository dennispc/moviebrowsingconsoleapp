
using System.Collections.Generic;

namespace moviebrowsingconsoleapp.IInfrastructure
{
    public interface IFakeDB
    {
        Movie addMovie(Movie movie);
        Movie getMovie();
        bool deleteMovie();
        bool updateMovie(Movie movie);

        List<Movie> getAllMovies();
    }
}