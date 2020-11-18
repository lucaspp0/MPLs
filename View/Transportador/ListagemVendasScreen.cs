using System;

using static MPL.utils.ViewUtils;
using MPL.View.interfaces;
using System.Threading.Tasks;

namespace MPL.View.Transportador
{
  public class ListagemVendasScreen : IScreen
  {
    public  void Show()
    {
      ShowScreen("Mostrar Lista de venda");
    }
  }
}