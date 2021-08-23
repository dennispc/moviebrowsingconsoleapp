using moviebrowsingconsoleapp.DPcode.Core.Model;

namespace moviebrowsingconsoleapp.DPcode.UI.IServices{
    
    public interface IConsoleAsker{
        string GetStringFromTerminal(string str);
        int GetIntFromTerminal(string str);

        Movie CreateNewMovie();
        bool UpdateMovie();

        bool DeleteMovie();
    }
}