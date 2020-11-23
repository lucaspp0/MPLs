using System;

using MPL.View;
using MPL.View.interfaces;
using static MPL.utils.ViewUtils;

public class MainScreen : IScreen
{
  
  public  void Show()
  {
    string choice = GetInput(@" 
      1 - Login
      2 - Cadastro
Selecione uma ação:");

    if(choice == "1")
      MainViewManager.ChangeScreen(new LoginScreen());
    else if(choice == "2")
      MainViewManager.ChangeScreen(new RegisterScreen());
    else{
      ShowScreen("opção inválida");
      GetWaitingInput();
    }
  }
}
