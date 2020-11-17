using System;

using static MPL.utils.ViewUtils;
using MPL.View.interfaces;
using System.Threading.Tasks;

namespace MPL.View.Transportador
{
  public class MenuTransportadorScreen : IScreen
  {
    public async Task Show()
    {
      ShowScreen("MenuTransportadorScreen");
    }
  }
}