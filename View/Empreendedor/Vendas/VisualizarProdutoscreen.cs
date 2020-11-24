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
        int i = 0; 
        for(i=0;i<lista.Count;i++){
          ShowScreen((i+1)+" | Nome: "+lista[i].Produto.Nome+" | Quantidade: "+lista[i].Quantidade);
        }
        ShowScreen(""+i);
        int input = GetInputInt("Digite o número do produto para obter uma descrição ou digite -1 para sair");
        ShowScreen(""+i);
        ShowScreen(""+input);
        if(input <= i && input >= 0 ){
           ShowScreen($@"Detalhe do produto: 
                  Nome: {lista[input-1].Produto.Nome}
                 Valor: {lista[input-1].Produto.Valor}
             Categoria: {lista[input-1].Produto.Categoria}
            Quantidade: {lista[input-1].Quantidade}

            ");


        }else if(input == -1){
          MainViewManager.ChangeScreen(new MenuEmpreendedorScreen());
        }
  }
}
}
