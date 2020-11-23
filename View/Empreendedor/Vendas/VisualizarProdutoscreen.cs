using System;

using static MPL.utils.ViewUtils;
using MPL.View.interfaces;
using MPL.model;
using System.Collections.Generic;

namespace MPL.View.Empreendedor.Vendas
{
  public class VisualizarProdutoscreen : IScreen
  {
      public  void Show(){
        UsuarioEmpreendedor usuario = (MainViewManager.CurrentUser as UsuarioEmpreendedor);
        List<ItemEstoque> lista = usuario.Estoque;
        for(int i=0;i<lista.Count;i++){
          ShowScreen((i+1)+" | Nome: "+lista[i].Produto.Nome+" | Quantidade: "+lista[i].Quantidade);
        }
        string input = GetInput("Digite algo para sair");
        if(input != "͔")
          MainViewManager.ChangeScreen(new MenuEmpreendedorScreen());
      }
  }
}
