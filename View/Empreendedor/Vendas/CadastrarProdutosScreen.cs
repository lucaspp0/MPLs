using System;

using static MPL.utils.ViewUtils;
using MPL.View.interfaces;
using System.Threading.Tasks;

namespace MPL.View.Empreendedor
{
  class CadastrarProdutosScreen : IScreen
  {
      public Task Show(){
        ShowScreen("Cadastrar produtos");
      }
  }
}