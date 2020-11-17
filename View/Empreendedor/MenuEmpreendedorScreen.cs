using System;

using static MPL.utils.ViewUtils;
using MPL.View.interfaces;
using System.Threading.Tasks;

namespace MPL.View.Empreendedor
{
  public class MenuEmpreendedorScreen : IScreen
  {
    public async Task Show()
    {
      ShowScreen("MenuEmpreendedorScreen");
    }
  }
}