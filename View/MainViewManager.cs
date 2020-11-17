using System;

using MPL.View.interfaces;
using MPL.model;
using static MPL.utils.ViewUtils;

namespace MPL.View
{
    public class MainViewManager
    {
      
      public static bool runningProgram = false;
      private static IScreen currentScreen;
      public static Pessoa CurrentUser;
      

      public MainViewManager(IScreen currentScreen){
        ChangeScreen(currentScreen);
      }

      public static void ChangeScreen(IScreen currentScreen){
        MainViewManager.currentScreen = currentScreen;
      }

      public void Start(){
        if(!runningProgram) runningProgram = true;
        Run();
      }

      private void Run(){
        while(runningProgram && currentScreen != null){
          currentScreen.Show();
          ClearConsole();
        }
      }

    }
}
