using System;
using System.Threading.Tasks;
using MPL.View;
using MPL.View.interfaces;
using static MPL.utils.ViewUtils;

public class MainScreen : IScreen
{

  public string BuilMaindMenu(){
    return $@" 
      1 - Login
      2 - Cadastro
Selecione uma ação:";
  }
  public  void Show()
  {
    string choice = GetInput(BuilMaindMenu());
    if(choice == "1")
      MainViewManager.ChangeScreen(new LoginScreen());
    else if(choice == "2")
      MainViewManager.ChangeScreen(new RegisterScreen());
    else
      ShowScreen("opção inválida");

    ClearConsole();
  }
}