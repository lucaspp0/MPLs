using System;
using MPL.View;
using static MPL.utils.ViewUtils;

namespace MPL
{
    class Program
    {
        static void Main(string[] args)
        {
            new MainViewManager(new MainScreen()).Start();
        }
    }
}
