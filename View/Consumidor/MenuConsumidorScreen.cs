using System;

using static MPL.utils.ViewUtils;
using MPL.View.interfaces;
using System.Threading.Tasks;

namespace MPL.View.Consumidor
{
  public class MenuConsumidorScreen : IScreen
  {
    public  void Show()
    {
      ShowScreen("MenuConsumidorScreen");
    }
  }
}