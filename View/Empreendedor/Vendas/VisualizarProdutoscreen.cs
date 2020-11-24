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
        int cont = 1;
        foreach(ItemEstoque estoque in lista){
          ShowScreen(cont+" | Nome: "+estoque.Produto.Nome+" | Quantidade: "+estoque.Quantidade);
          cont++;
        }
        int input = GetInputInt("Digite o número do produto para obter uma descrição ou digite -1 para sair: ");
        if(input < cont && input >= 0 ){
           ShowScreen($@"Detalhe do produto: 
                  Nome: {lista[input-1].Produto.Nome}
                 Valor: {lista[input-1].Produto.Valor}
             Categoria: {lista[input-1].Produto.Categoria}
            Quantidade: {lista[input-1].Quantidade}
            ");
          
          GetInput("Digite algo para voltar a tela inicial");
          MainViewManager.ChangeScreen(new MenuEmpreendedorScreen());


        }else if(input == -1){
          MainViewManager.ChangeScreen(new MenuEmpreendedorScreen());
        }
  }
}
}
