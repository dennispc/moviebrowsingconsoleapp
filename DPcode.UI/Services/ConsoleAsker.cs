using System;
using moviebrowsingconsoleapp.DPcode.Core.Model;
using moviebrowsingconsoleapp.DPcode.Domain;
using moviebrowsingconsoleapp.DPcode.UI.IServices;

namespace moviebrowsingconsoleapp.DPcode.UI.Services
{
    public class ConsoleAsker : IConsoleAsker
    {
        private IDataManager _dataManager;

        public ConsoleAsker(IDataManager dataManager)
        {
            _dataManager = dataManager;
        }
        public int GetIntFromTerminal(string str)
        {
            Console.Write(str);
            string year = Console.ReadLine();
            int validYear;

            while (!int.TryParse(year, out validYear))
            {
                Console.WriteLine("That's not valid.");
                Console.Write(str);
                year = Console.ReadLine();
            }
            return validYear;
        }

        public string GetStringFromTerminal(string str)
        {
            string text = "";
            while (text.Trim() == "")
            {
                Console.Write(str);
                text = Console.ReadLine();
            }
            return text;
        }
        public Movie CreateNewMovie()
        {
            string title = GetStringFromTerminal("title:");
            int validYear = GetIntFromTerminal("Year: ");
            return new Movie(validYear, title);
        }

        public bool UpdateMovie()
        {
            Movie mov = _dataManager.GetMovie(GetIntFromTerminal("Id to update: "));
            if (mov != null)
            {
                Console.WriteLine($"old title: {mov.title}, old year: {mov.year}");
                string title = GetStringFromTerminal("title:");
                int validYear = GetIntFromTerminal("Year: ");
                mov.title = title;
                mov.year = validYear;
            }
            return mov != null;
        }

        public bool DeleteMovie()
        {
            int id = GetIntFromTerminal("Id to delete: ");
            Movie movie = _dataManager.GetMovie(id);
            if (movie != null)
            {
                Console.WriteLine($"Confirm deleting {movie.GetId()} ; {movie.year} ; {movie.title}");
                string confirmation = GetStringFromTerminal("Write YES to confirm: ");
                if (confirmation.ToLower() == "yes" || confirmation == "YES to confirm:")
                {
                    return _dataManager.DeleteMovie(movie);
                }
            }
            return false;
        }
    }
}