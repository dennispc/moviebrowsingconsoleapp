using System;
using System.Collections.Generic;
using moviebrowsingconsoleapp.DPcode.Core.IModel;
using moviebrowsingconsoleapp.DPcode.UI.IServices;

namespace moviebrowsingconsoleapp.DPcode.UI.Services
{
    public class ConsoleTreeHandler : IConsoleTreeHandler
    {
        private IMenu _menu;
        private IConsoleAsker _consoleAsker;

        public ConsoleTreeHandler(IMenu _menu, IConsoleAsker consoleAsker){
            this._menu=_menu;
            this._consoleAsker=consoleAsker;
        }
        public IMenu GetCurrentBranch()
        {
            return _menu;
        }

        public string GetResponse()
        {
            int number = _consoleAsker.GetIntFromTerminal("");
            if(number<_menu.GetBraches().Count)
            return _menu.GetBraches()[number-1].GetDescriptor();
            else 
            throw new ArgumentOutOfRangeException();
        }

        public void PrintMenu()
        {
            Console.WriteLine();
            List<IMenu> menus = _menu.GetBraches();
            for(int i = 0; i< menus.Count;i++)
            {
                Console.WriteLine($"{(i+1)} : {menus[i].GetDescriptor()}");
            }
        }
        public void PrintMenu(IMenu menu)
        {
            List<IMenu> menus = menu.GetBraches();
            for(int i = 0; i< menus.Count;i++)
            {
                Console.WriteLine($"{i} : {menus[i].GetDescriptor()}");
            }
        }
    }
}