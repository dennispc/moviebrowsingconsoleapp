
using System.Collections.Generic;
using moviebrowsingconsoleapp.DPcode.Core.Model;

namespace moviebrowsingconsoleapp.DPcode.Infrastructure.Data.IRepositories
{
    public interface IFakeDB
    {
        Movie AddMovie(Movie movie);
        bool DeleteMovie(Movie movie);
        bool updateMovie(Movie movie);

        List<Movie> GetAllMovies();
    }
}