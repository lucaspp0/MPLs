using System;

using MPL.View;
using MPL.View.interfaces;
using static MPL.utils.ViewUtils;

public class MainScreen : IScreen
{
  
  public  void Show()
  {
    string choice = GetInput(@" 
Área inicial MPL's

      1 - Login
      2 - Cadastro
      3 - Sair
Selecione uma ação: ");

    if(choice == "1")
      MainViewManager.ChangeScreen(new LoginScreen());
    else if(choice == "2")
      MainViewManager.ChangeScreen(new RegisterScreen());
    else if(choice == "3"){
      MainViewManager.runningProgram = false;
      ShowScreen("Obrigado por usar o sistema");
      GetWaitingInput();
    }
    else{
      ShowScreen("opção inválida");
      GetWaitingInput();
    }
  }
}
