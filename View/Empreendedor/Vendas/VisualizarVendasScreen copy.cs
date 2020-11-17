using System;

using static MPL.utils.ViewUtils;
using MPL.View.interfaces;
using System.Threading.Tasks;

namespace MPL.View.Empreendedor
{
  class VisualizarVendasScreen : IScreen
  {
      public Task Show(){
        ShowScreen("Listar vendas");
      }
  }
}