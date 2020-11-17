using System;

using static MPL.utils.ViewUtils;
using MPL.View.interfaces;
using System.Threading.Tasks;

namespace MPL.View.Consumidor
{
  public class MenuConsumidorScreen : IScreen
  {
    public async Task Show()
    {
      ShowScreen("MenuConsumidorScreen");
    }
  }
}