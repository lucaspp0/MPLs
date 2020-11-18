using System.Threading.Tasks;
using System;

using static MPL.utils.ViewUtils;
using MPL.View.interfaces;
using MPL.View;
using MPL.utils;
using MPL.model;
using MPL.View.Consumidor;
using MPL.View.Empreendedor;
using MPL.View.Transportador;

public class LoginScreen : IScreen
{
  public async Task Show()
  {

    
    string validateLogin = GetInput("Digite 1 para voltar ao cadastro: ");
    if(validateLogin != "1"){

      string login = GetInput("insira seu login: ");
      string senha = GetInput("insira a sua senha: ");

    bool loginSucess = await Injector.ClientController.Login(login, senha);
    if (loginSucess)
    {

      if (MainViewManager.CurrentUser is UsuarioConsumidor) MainViewManager.ChangeScreen(new MenuConsumidorScreen());
      else if (MainViewManager.CurrentUser is UsuarioEmpreendedor) MainViewManager.ChangeScreen(new MenuEmpreendedorScreen());
      else if (MainViewManager.CurrentUser is ContaTransportador) MainViewManager.ChangeScreen(new MenuTransportadorScreen());
      else
      {
        ShowScreen("Tipo de usuário não encontrado");
        GetWaitingInput();
      }

    }
    else
    {
      ShowScreen("Login incorreto");
      GetWaitingInput();
      MainViewManager.ChangeScreen(new MainScreen());
    }

  }
}