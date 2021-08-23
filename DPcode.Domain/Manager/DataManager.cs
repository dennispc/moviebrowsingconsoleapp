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
            _fakeDB.deleteMovie(movie);
            return false;
        }

        public List<Movie> GetAllMovies()
        {
            return _fakeDB.getAllMovies();
        }

        public Movie GetMovie(int id)
        {
            return GetAllMovies().Find(m=>m.GetId()==id);
        }

        public bool UpdateMovie(Movie movie)
        {
            return _fakeDB.updateMovie(movie);
        }
    }
}