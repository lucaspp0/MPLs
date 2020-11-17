using System;

using static MPL.utils.ViewUtils;
using MPL.View.interfaces;
using System.Threading.Tasks;

namespace MPL.View.Empreendedor.Vendas
{
  public class VisualizarProdutoscreen : IScreen
  {
      public async Task Show(){
        ShowScreen("Listar produtos");
      }
  }
}