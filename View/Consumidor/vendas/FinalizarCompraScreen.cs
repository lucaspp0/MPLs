using System;

using static MPL.utils.ViewUtils;
using MPL.View.interfaces;


namespace MPL.View.Consumidor.vendas
{
  public class FinalizarCompraScreen : IScreen
  {
    public  void Show()
    {
      ShowScreen("Finalizar Compra");
      GetWaitingInput();
      MainViewManager.ChangeScreen(new MenuConsumidorScreen());
    }
  }
}
