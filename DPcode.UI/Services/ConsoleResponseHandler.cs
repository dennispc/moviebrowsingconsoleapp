
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
                case "Update movies" :
                UpdateMovie();
                break;
                case "Delete movie" :
                DeleteMovie();
                break;
                case "stop":
                Stop();
                break;
                default :
                throw new System.NotImplementedException();
            }
            Program.Init();
        }

        private void Stop()
        {
            Program.FlipStopBool();
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
            _consoleAsker.UpdateMovie();
        }
         public void DeleteMovie()
        {
            if(_consoleAsker.DeleteMovie())
            Console.WriteLine("Success!");
            else
            Console.WriteLine("Something went wrong!");
        }
    }
}