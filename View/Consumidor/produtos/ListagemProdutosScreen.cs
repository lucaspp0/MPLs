using System;

using static MPL.utils.ViewUtils;
using MPL.View.interfaces;
using System.Threading.Tasks;

namespace MPL.View.Consumidor.produtos
{
  public class ListagemProdutosScreen : IScreen
  {
    public  void Show()
    {
      
      string result = GetInput($"digite o nome do produto: ");
      ShowScreen("Mostrar Listagem do produto");
      result = GetInput($"digite o id do produto ou -1 para sair");
      if(result == "-1") MainViewManager.ChangeScreen( new MenuConsumidorScreen() );
      else{
        ShowScreen("ir para o detalhamento do produto");
        GetWaitingInput();
        MainViewManager.ChangeScreen(new MenuConsumidorScreen());
        // MainViewManager.ChangeScreen( new MenuConsumidorScreen(null) );
      }
        
    }
  }
}