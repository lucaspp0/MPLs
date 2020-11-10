using System;

using static MPL.utils.ViewUtils;
using MPL.View.interfaces;

public class LoginScreen : IScreen
{

  public string BuilMaindMenu(){
    return $@"";
  }
  public void Show()
  {
    ShowScreen(BuilMaindMenu());
  }
}