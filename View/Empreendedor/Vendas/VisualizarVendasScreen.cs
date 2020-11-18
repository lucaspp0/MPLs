using System;

using static MPL.utils.ViewUtils;
using MPL.View.interfaces;
using System.Threading.Tasks;

namespace MPL.View.Empreendedor.Vendas
{
  public class VisualizarVendasScreen : IScreen
  {
      public  void Show(){
        ShowScreen("Listar vendas");
      }
  }
}