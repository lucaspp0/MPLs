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
      
      string result = GetInput($@"
      1 - Visualizar Vendas
      2 - Visualizar produtos
      3 - Cadastrar produtos
      4 - Deletar Produtos

Digite a opção: ");

      if(result == "1"){
        
      }else if(result == "2"){
        
      }else if(result == "3"){
        
      }else if(result == "4"){
        
      }else{
        ShowScreen("Escolha inválida");
        GetWaitingInput();
      }
    }
  }
}