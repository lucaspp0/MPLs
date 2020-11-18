using System;
using MPL.utils;
using static MPL.utils.ViewUtils;
using MPL.View.interfaces;
using System.Threading.Tasks;

namespace MPL.View
{
  public class RegisterScreen : IScreen
  {
    public async Task Show()
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
        loginSucess = await Injector.ClienteEmpreenderController.RegisterClienteEmpreende(nome,login,senha,cnpj);
      }else if(tipo == "2"){
        string cpf = GetInput("Informe o CPF: ");
        loginSucess = await Injector.ClienteConsumidorController.RegisterClienteConsumidor(nome,login,senha,cpf);
      }else{
        ShowScreen("tipo de usuário invalido");  
      }

      ShowScreen($"tipo de usuario {tipo}");
      if(loginSucess){
        new LoginScreen().Show();
      }else{
        new RegisterScreen().Show();
      }
      
      GetWaitingInput();
    }
  }
}