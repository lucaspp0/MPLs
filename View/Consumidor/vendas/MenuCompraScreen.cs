using System.Linq;
using System.Collections.Generic;

using MPL.utils;
using MPL.model;
using MPL.View.interfaces;
using MPL.repository;
using static MPL.utils.ViewUtils;
using MPL.View.Consumidor.produtos;

namespace MPL.View.Consumidor.vendas
{
  public class MenuCompraScreen : IScreen
  {
    public void Show()
    {
      ShowScreen("mostrar Todas as comprars do usuario");
      GetWaitingInput();
    }
  }
}
