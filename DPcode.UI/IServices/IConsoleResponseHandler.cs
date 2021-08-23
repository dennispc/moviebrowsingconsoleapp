namespace moviebrowsingconsoleapp.DPcode.UI.IServices
{
    public interface IConsoleResponseHandler
    {
        void HandleResonse(string str);

        void CreateMovie();
        void ListMovies();
        void UpdateMovie();
        void DeleteMovie();
    }
}