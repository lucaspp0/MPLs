using System;

using static MPL.utils.ViewUtils;
using MPL.View.interfaces;
using System.Threading.Tasks;

namespace MPL.View.Empreendedor.Vendas
{
  public class DeletarProdutosScreen : IScreen
  {
      public async Task Show(){
        ShowScreen("Deletar Produtos");
      }
  }
}