using System;

using static MPL.utils.ViewUtils;
using MPL.View.interfaces;
using System.Threading.Tasks;

namespace MPL.View.Transportador
{
  public class MenuTransportadorScreen : IScreen
  {
    public  void Show()
    {
      string result = GetInput($@"
      1 - Alterar Status Venda
      2 - Sair
  Digite a opção: ");

      if(result == "1"){
        MainViewManager.ChangeScreen(new ListagemVendasScreen());
      }else if(result == "2"){
        MainViewManager.logout();
      }else{
        ShowScreen("Escolha inválida");
        GetWaitingInput();
      }
      
    }
  }
}