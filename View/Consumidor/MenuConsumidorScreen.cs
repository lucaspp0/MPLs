using System;

using static MPL.utils.ViewUtils;
using MPL.View.interfaces;
using MPL.View.Consumidor.produtos;
using MPL.View.Consumidor.vendas;

namespace MPL.View.Consumidor
{
  public class MenuConsumidorScreen : IScreen
  {
    public  void Show()
    {
      
      string result = GetInput($@"
      1 - Visualizar Compras
      2 - Procurar produtos
      3 - Visualizar Carrinha
      5 - Sair

Digite a opção: ");

      if(result == "1"){
        new MenuCompraScreen().Show();
      }else if(result == "2"){
        new ListagemProdutosScreen().Show();
      }else if(result == "3"){
        new MenuCarrinhoScreen().Show();
      }else if(result == "5"){
        MainViewManager.logout();
      }else{
        ShowScreen("Escolha inválida");
        GetWaitingInput();
      }
    }
  }
}