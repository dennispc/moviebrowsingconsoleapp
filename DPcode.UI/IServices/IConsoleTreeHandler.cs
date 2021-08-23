using moviebrowsingconsoleapp.DPcode.Core.IModel;

namespace moviebrowsingconsoleapp.DPcode.UI.IServices{
    public interface IConsoleTreeHandler{
        void PrintMenu();
        void PrintMenu(IMenu menu);
        string GetResponse();

        IMenu GetCurrentBranch();

        
    }
}