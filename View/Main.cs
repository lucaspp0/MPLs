using System;
using MPL.View.interfaces;

namespace MPL.View
{
    class MainViewManager
    {

      public static bool runningProgram = false;
      private static IScreen currentScreen;

      public MainViewManager(IScreen currentScreen){
        this.changeScreen(currentScreen);
      }

      public void changeScreen(IScreen currentScreen){
        MainViewManager.currentScreen = currentScreen;
      }

      public void Start(){
        if(!runningProgram) runningProgram = true;
        Run();
      }

      private void Run(){
        while(runningProgram && currentScreen != null){
          currentScreen.Show();
        }
      }

    }
}
