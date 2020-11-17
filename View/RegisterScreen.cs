using System;

using static MPL.utils.ViewUtils;
using MPL.View.interfaces;
using System.Threading.Tasks;

namespace MPL.View
{
  public class RegisterScreen : IScreen
  {
    public async Task Show()
    {
      ShowScreen("RegisterScreen");
    }
  }
}