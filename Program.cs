using System;
using static MPL.utils.ViewUtils;

namespace MPL
{
    class Program
    {
        static void Main(string[] args)
        {
            string kk = GetInput("Digite algo por favor: ");
            ShowScreen(kk);
            GetWaitingInput();
            ClearConsole();
            ShowScreen("final");
        }
    }
}
