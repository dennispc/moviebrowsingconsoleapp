using System;
using System.Collections.Generic;
using moviebrowsingconsoleapp.IModel;
using moviebrowsingconsoleapp.Model;
using moviebrowsingconsoleapp.IServices;
using moviebrowsingconsoleapp.Services;

namespace moviebrowsingconsoleapp
{
    class Program
    {


        static void Main(string[] args){

            IMenu menu = new Menu("start");

            IMenu menu2 = new Menu("start2");
            IMenu menu3 = new Menu("start3");
            
            menu.AddBranch(menu2);
            menu.AddBranch(menu3);

            IConsoleTreeHandler consoleTreeHandler = new ConsoleTreeHandler(menu);

            consoleTreeHandler.PrintMenu();
            consoleTreeHandler.GetResponse();
        }
    }
}