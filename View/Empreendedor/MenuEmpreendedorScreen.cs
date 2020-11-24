using System;

using static MPL.utils.ViewUtils;
using MPL.View.interfaces;

using MPL.View.Empreendedor.Vendas;

namespace MPL.View.Empreendedor
{
  public class MenuEmpreendedorScreen : IScreen
  {
    public  void Show()
    {
      
      string result = GetInput($@"
      Área do Empreendedor

      1 - Visualizar Vendas
      2 - Visualizar produtos
      3 - Cadastrar produtos
      4 - Sair

Digite a opção: ");

      if(result == "1"){
        MainViewManager.ChangeScreen(new VisualizarVendasScreen());
      }else if(result == "2"){
        MainViewManager.ChangeScreen(new VisualizarProdutoscreen());
      }else if(result == "3"){
        MainViewManager.ChangeScreen(new CadastrarProdutosScreen());
      }else if(result == "4"){
        MainViewManager.logout();
      }else{
        ShowScreen("Escolha inválida");
        GetWaitingInput();
      }
    }
  }
}
