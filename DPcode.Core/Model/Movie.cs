using System;
using moviebrowsingconsoleapp.IServices;
using moviebrowsingconsoleapp.Services;
namespace moviebrowsingconsoleapp{
    public class Movie{

        public string title{get;set;}
        public int year{get;set;}
        private int _id;

        public Movie(int year, string title){
            this.title=title;
            this.year=year;
        }

        public Movie(int _id, int year, string title){
            this._id=_id;
            this.year=year;
            this.title=title;
        }

        public static Movie NewMovie()
        {
            IConsoleAsker consoleAsker = new ConsoleAsker();
            string title = consoleAsker.GetStringFromTerminal("title:");
            int validYear = consoleAsker.GetIntFromTerminal("Year: ");
            return new Movie(validYear,title);
        }
    }
}