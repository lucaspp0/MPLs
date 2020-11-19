using System;

using static MPL.utils.ViewUtils;
using MPL.View.interfaces;
using System.Threading.Tasks;

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

      if(result == "1"){
        ShowScreen("Realizar compra");
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