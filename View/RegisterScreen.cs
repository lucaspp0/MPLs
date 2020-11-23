using System;
using MPL.utils;
using static MPL.utils.ViewUtils;
using MPL.View.interfaces;


namespace MPL.View
{
  public class RegisterScreen : IScreen
  {
    public  void Show()
    {
      bool loginSucess = false;

      string tipo = GetInput($@"Tipos de usuários
      1 - Usuário Empreendedor
      2 - Usuário Consumidor
Escolha o tipo de usuário: ");
    
      string login = GetInput("Informe o Login: ");
      string senha = GetInput("Informe o Senha:");
      string nome = GetInput("Informe o Nome: ");

      if(tipo == "1") {
        string cnpj = GetInput("Informe o CPNJ: ");
        loginSucess = Injector.ClienteEmpreenderController.RegisterClienteEmpreende(nome,login,senha,cnpj);
      }else if(tipo == "2"){
        string cpf = GetInput("Informe o CPF: ");
        loginSucess = Injector.ClienteConsumidorController.RegisterClienteConsumidor(nome,login,senha,cpf);
      }else{
        ShowScreen("tipo de usuário invalido");  
        GetWaitingInput();
      }
      
      if(loginSucess) MainViewManager.ChangeScreen(new LoginScreen());
      else MainViewManager.ChangeScreen(new MainScreen());
      
    }
  }
}
