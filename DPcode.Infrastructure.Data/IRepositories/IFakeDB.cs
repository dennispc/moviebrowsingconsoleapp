
using System.Collections.Generic;
using moviebrowsingconsoleapp.DPcode.Core.Model;

namespace moviebrowsingconsoleapp.DPcode.Infrastructure.Data.IRepositories
{
    public interface IFakeDB
    {
        Movie AddMovie(Movie movie);
        Movie getMovie(int id);
        bool deleteMovie(Movie movie);
        bool updateMovie(Movie movie);

        List<Movie> getAllMovies();
    }
}