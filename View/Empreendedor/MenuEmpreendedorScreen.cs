using System;

using static MPL.utils.ViewUtils;
using MPL.View.interfaces;
using System.Threading.Tasks;
using MPL.View.Empreendedor.Vendas;

namespace MPL.View.Empreendedor
{
  public class MenuEmpreendedorScreen : IScreen
  {
    public async Task Show()
    {
      
      string result = GetInput($@"
      1 - Visualizar Vendas
      2 - Visualizar produtos
      3 - Cadastrar produtos
      4 - Deletar Produtos
      5 - Sair

Digite a opção: ");

      if(result == "1"){
        new VisualizarVendasScreen().Show();
      }else if(result == "2"){
        new VisualizarProdutoscreen().Show();
      }else if(result == "3"){
        new CadastrarProdutosScreen().Show();
      }else if(result == "4"){
        new DeletarProdutosScreen().Show();
      }else if(result == "5"){
        MainViewManager.logout();
      }else{
        ShowScreen("Escolha inválida");
        GetWaitingInput();
      }
    }
  }
}