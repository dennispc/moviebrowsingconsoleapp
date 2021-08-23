namespace moviebrowsingconsoleapp.IModel{
    public interface IConsoleTreeHandler{
        void PrintMenu();
        void PrintMenu(IMenu menu);
        int GetResponse();

        IMenu GetCurrentBranch();

        
    }
}