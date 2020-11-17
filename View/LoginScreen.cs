using System.Threading.Tasks;
using System;

using static MPL.utils.ViewUtils;
using MPL.View.interfaces;
using MPL.View;
using MPL.utils;
using MPL.model;


public class LoginScreen : IScreen
{
    public async Task Show()
  {

    string login = GetInput("insira seu login: ");
    string senha = GetInput("insira a sua senha: ");

    bool loginSucess = await Injector.ClientController.Login(login, senha);
    if(loginSucess){
      if(MainViewManager.CurrentUser is UsuarioConsumidor){
        
      }else if(MainViewManager.CurrentUser is UsuarioEmpreendedor){

      }else if(MainViewManager.CurrentUser is ContaTransportador){

      }else{
        ShowScreen("Tipo de usuário não encontrado");
        GetWaitingInput();
      }
    }else{
      ShowScreen("Login incorreto");
      GetWaitingInput();
    }
    
  }
}