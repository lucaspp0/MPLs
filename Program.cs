using System.Threading.Tasks;
using System;

using MPL.utils;
using static MPL.utils.ViewUtils;
using MPL.repository.impl;
using MPL.View;

namespace MPL
{
    public class Program
    {
        
        public async static Task InitializeComponentes(){
            await BaseRepository<object>.FillBdByFile();
            Injector.initialize();
        }

        public async static Task init() {
            await Program.InitializeComponentes(); 
            new MainViewManager(new MainScreen()).Start();
        }

        static void Main(string[] args)
        {
            ClearConsole();
            Task mainTask = init();

            while(!mainTask.IsCompleted) { }
            Console.WriteLine("Final");
        }
    }
}
