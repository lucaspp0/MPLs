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
      3 - Visualizar Carrinho
      4 - finalizar Compra
      5 - Sair

Digite a opção: ");

      if(result == "1"){
        MainViewManager.ChangeScreen(new MenuCompraScreen());
      }else if(result == "2"){
        MainViewManager.ChangeScreen(new ListagemProdutosScreen());
      }else if(result == "3"){
        MainViewManager.ChangeScreen(new MenuCarrinhoScreen());
      }else if(result == "4"){
        MainViewManager.ChangeScreen(new MenuCarrinhoScreen());
      }else if(result == "5"){
        MainViewManager.logout();
      }else{
        ShowScreen("Escolha inválida");
        GetWaitingInput();
      }
    }
  }
}
