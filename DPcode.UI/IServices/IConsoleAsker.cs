namespace moviebrowsingconsoleapp.IServices{
    public interface IConsoleAsker{
        public string GetStringFromTerminal(string str);
        public int GetIntFromTerminal(string str);
    }
}