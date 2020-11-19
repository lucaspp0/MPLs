using System;

using static MPL.utils.ViewUtils;
using MPL.View.interfaces;
using System.Threading.Tasks;

namespace MPL.View.Consumidor.vendas
{
  public class MenuCompraScreen : IScreen
  {
    public  void Show()
    {
      ShowScreen("Mostrar Compras do usuário");
      string result = GetInput("selecione um produto para detalhar ou -1 parar sair");
      if(result == "-1") MainViewManager.ChangeScreen( new MenuConsumidorScreen() );
    }
  }
}