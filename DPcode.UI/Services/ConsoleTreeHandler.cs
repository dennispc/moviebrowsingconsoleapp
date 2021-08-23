using System;
using System.Collections.Generic;
using moviebrowsingconsoleapp.IModel;
using moviebrowsingconsoleapp.IServices;
using moviebrowsingconsoleapp.Services;

namespace moviebrowsingconsoleapp.Model
{
    public class ConsoleTreeHandler : IModel.IConsoleTreeHandler
    {
        private IMenu _menu;

        public ConsoleTreeHandler(IMenu _menu){
            this._menu=_menu;
        }
        public IMenu GetCurrentBranch()
        {
            return _menu;
        }

        public int GetResponse()
        {
            IConsoleAsker consoleAsker = new ConsoleAsker();
            int number = consoleAsker.GetIntFromTerminal("");
            _menu = _menu.GetBraches()[number-1];
            return number;
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