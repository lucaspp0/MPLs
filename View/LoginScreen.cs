using System.Threading.Tasks;
using System;

using static MPL.utils.ViewUtils;
using MPL.View.interfaces;
using MPL.View;
using MPL.utils;


public class LoginScreen : IScreen
{
    public async Task Show()
  {

    string login = GetInput("insira seu login: ");
    string senha = GetInput("insira a sua senha: ");

    bool loginSucess = await Injector.LoginController.DoLogin(login, senha);
    /*
    if(loginSucess) MainViewManager.ChangeScreen(new UserScreen());
    else ShowScreen("Login inválido");
    */
    
  }
}