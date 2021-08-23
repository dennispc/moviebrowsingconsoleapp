using System.Collections.Generic;
using moviebrowsingconsoleapp.DPcode.Core.Model;
using moviebrowsingconsoleapp.DPcode.Infrastructure.Data.IRepositories;

namespace moviebrowsingconsoleapp.DPcode.Domain.Manager
{
    public class DataManager : IDataManager
    {

        private IFakeDB _fakeDB;
        public DataManager(IFakeDB fakeDB){
            _fakeDB=fakeDB;
        }

        public bool AddMovie(Movie movie)
        {
            _fakeDB.AddMovie(movie);
            return true;
        }

        public bool DeleteMovie(Movie movie)
        {
            return _fakeDB.DeleteMovie(movie);
        }

        public List<Movie> GetAllMovies()
        {
            return _fakeDB.GetAllMovies();
        }

        public Movie GetMovie(int id)
        {
            List<Movie> movies = GetAllMovies();
            for (int i = 0; i < movies.Count; i++)
            {
                if(movies[i].GetId().Equals(id))
                    return movies[i];
            }
            return new Movie(1,"");
        }

        public bool UpdateMovie(Movie movie)
        {
            return _fakeDB.updateMovie(movie);
        }
    }
}