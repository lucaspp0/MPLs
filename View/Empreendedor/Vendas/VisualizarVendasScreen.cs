using System;

using static MPL.utils.ViewUtils;
using MPL.View.interfaces;


namespace MPL.View.Empreendedor.Vendas
{
  public class VisualizarVendasScreen : IScreen
  {
      public  void Show(){
        ShowScreen("Listar vendas");
      }
  }
}
