using System;

using static MPL.utils.ViewUtils;
using MPL.View.interfaces;
using MPL.model;
using MPL.utils;

namespace MPL.View.Consumidor.vendas
{
  public class MenuCarrinhoScreen : IScreen
  {
    public  void Show()
    {
      
      string result = GetInput($@"
      1 - Realizar Compra
      2 - Remover Produto
      5 - Sair

Digite a opção: ");
      UsuarioConsumidor usuarioConsumidor = MainViewManager.CurrentUser as UsuarioConsumidor;
      if(result == "1"){

        if(Injector.CarrinhoController.ExisteCarrinho(usuarioConsumidor)){
          
        }else{
          ShowScreen("Carrinho Vázio");
        }

        GetWaitingInput();
      }else if(result == "2"){
        result = GetInput("Selecione o id do produot: ");
        ShowScreen($"produto {result} selecionado para remoção");
        GetWaitingInput();
      }else if(result == "3"){
        MainViewManager.ChangeScreen( new MenuConsumidorScreen() );
      }else{
        ShowScreen("Escolha inválida");
        GetWaitingInput();
      }
    }
  }
}
