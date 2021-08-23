using System;
using moviebrowsingconsoleapp.DPcode.Core.Model;
using moviebrowsingconsoleapp.DPcode.UI.IServices;

namespace moviebrowsingconsoleapp.DPcode.UI.Services
{
    public class ConsoleAsker : IConsoleAsker
    {
        public int GetIntFromTerminal(string str)
        {
            Console.Write(str);
            string year = Console.ReadLine();
            int validYear;

            while(!int.TryParse(year,out validYear)){
                Console.WriteLine("That's not valid.");
                Console.Write(str);
                year=Console.ReadLine();
                Console.WriteLine();
            }
            return validYear;
        }

        public string GetStringFromTerminal(string str)
        {
            string text = "";
            while(text.Trim()==""){
                Console.Write(str);
                text=Console.ReadLine();
                Console.WriteLine("");
            }
            return text;
        }
        public Movie CreateNewMovie()
        {
            string title = GetStringFromTerminal("title:");
            int validYear = GetIntFromTerminal("Year: ");
            return new Movie(validYear,title);
        }
    }
}