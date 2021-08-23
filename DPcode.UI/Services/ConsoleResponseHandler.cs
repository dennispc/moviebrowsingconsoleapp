
using moviebrowsingconsoleapp.DPcode.Domain;
using moviebrowsingconsoleapp.DPcode.UI.IServices;
using System;
namespace moviebrowsingconsoleapp.DPcode.UI.IServices
{
    public class ConsoleResponseHandler : IConsoleResponseHandler
    {

        private IConsoleAsker _consoleAsker;
        private IDataManager _dataManager;
        public ConsoleResponseHandler(IConsoleAsker consoleAsker, IDataManager dataManager){
            _consoleAsker=consoleAsker;
            _dataManager=dataManager;
        }

        public void HandleResonse(string str)
        {
            switch(str){
                case "Create Movie" :
                CreateMovie();
                break;
                case "List movies" :
                ListMovies();
                break;
                default :
                throw new System.NotImplementedException();
            }
            Program.Init();
        }

        public void CreateMovie()
        {
            _dataManager.AddMovie(_consoleAsker.CreateNewMovie());
        }

        public void ListMovies()
        {
            _dataManager.GetAllMovies().ForEach(movie=>Console.WriteLine($"{movie.GetId()} ; {movie.year} ; {movie.title}"));
        }

        public void UpdateMovie()
        {
            throw new System.NotImplementedException();
        }
         public void DeleteMovie()
        {
            throw new System.NotImplementedException();
        }
    }
}