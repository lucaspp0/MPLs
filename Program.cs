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
        
        public static void InitializeComponentes(){
            BaseRepository<object>.FillBdByFile();
            Injector.initialize();
        }

        public static void Init() {
            Program.InitializeComponentes(); 
            new MainViewManager(new MainScreen()).Start();
        }

        public static void Main(string[] args)
        {
            ClearConsole();
            Program.Init();
        }
    }
}