using System;
using System.Collections.Generic;
using moviebrowsingconsoleapp.DPcode.UI.IServices;
using moviebrowsingconsoleapp.DPcode.UI.Services;
using moviebrowsingconsoleapp.DPcode.Core.IModel;
using moviebrowsingconsoleapp.DPcode.Core.Model;
using moviebrowsingconsoleapp.DPcode.Infrastructure.Data.IRepositories;
using moviebrowsingconsoleapp.Infrastructure;
using moviebrowsingconsoleapp.DPcode.Domain;
using moviebrowsingconsoleapp.DPcode.Domain.Manager;

namespace moviebrowsingconsoleapp
{
    class Program
    {
            public static IMenu menu = new Menu("intial menu");

            public static IMenu menu1 = new Menu("Create Movie");
            public static IMenu menu2 = new Menu("List movies");
            public static IMenu menu3 = new Menu("Update movies");
            public static IMenu menu4 = new Menu("Delete movie");

            static IFakeDB fakeDB = new FakeDB();
            static IDataManager dataManager = new DataManager(fakeDB);
            static IConsoleAsker consoleAsker = new ConsoleAsker(dataManager);
            static IConsoleTreeHandler consoleTreeHandler = new ConsoleTreeHandler(menu, consoleAsker);
            static IConsoleResponseHandler consoleResponseHandler = new ConsoleResponseHandler(consoleAsker,dataManager);

            static bool stop = false;


        static void Main(string[] args){
            menu.AddBranch(menu1);
            menu.AddBranch(menu2);
            menu.AddBranch(menu3);
            menu.AddBranch(menu4);

            Init();

            
        }

        public static void Init(){
            if(!stop){
            consoleTreeHandler.PrintMenu();
            consoleResponseHandler.HandleResonse(consoleTreeHandler.GetResponse());
            }
        }

        public static void FlipStopBool(){
            stop = ! stop;
        }
    }
}