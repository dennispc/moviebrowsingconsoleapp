using System.Collections.Generic;
using moviebrowsingconsoleapp.DPcode.Core.Model;

namespace moviebrowsingconsoleapp.DPcode.Domain
{
    public interface IDataManager
    {
        Movie GetMovie(int id);

        bool AddMovie(Movie movie);

        List<Movie> GetAllMovies();

        bool DeleteMovie(Movie movie);

        bool UpdateMovie(Movie movie);
    }
}