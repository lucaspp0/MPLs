// DetalheproutoScreen
using System;

using static MPL.utils.ViewUtils;
using MPL.model;
using MPL.utils;
using MPL.View.interfaces;
using MPL.controller;

namespace MPL.View.Consumidor.produtos
{
  
  public class DetalheProdutoScreen : IScreen
  {

    private ItemEstoque _itemEstoque;
    private CarrinhoController _CarrinhoController;
    private ItemEstoqueController _ItemEstoqueController;
    
    public DetalheProdutoScreen(ItemEstoque itemEstoque){
      this._itemEstoque = itemEstoque;
      this._CarrinhoController = Injector.CarrinhoController;
      this._ItemEstoqueController = Injector.ItemEstoqueController;
    }

    public void Show()
    {
      ShowScreen(this._itemEstoque.Produto.ToString()+"Qtd. Estoque: "+this._itemEstoque.Quantidade);

      int result = GetInputInt(@"
        Opções
        1 - Adicionar ao carrinho
        2 - parar sair        
Selecione uma das opções acima: ");
      switch (result)
      {
          case 1:
            AdicionarAoCarrinho();
            break;
          case 2:
            VoltarListagemProduto();
            break;
          default:
            ShowScreen("opção inválida");
            GetWaitingInput();
            break;
      }
    }

    private void VoltarListagemProduto() => 
      MainViewManager.ChangeScreen(new ListagemProdutosScreen());

    private void AdicionarAoCarrinho(){
      UsuarioConsumidor UsuarioConsumidor = (MainViewManager.CurrentUser as UsuarioConsumidor);
      Envio envio = null;
      int quantidade = GetInputInt("Digite a quantidade que deseja comprar, ou -1 para sair");
      while(quantidade != -1 && quantidade >= this._itemEstoque.Quantidade){
        quantidade = GetInputInt(@"quantidade maior que o estoque permitido
Digite um valor válido, ou -1 para sair: ");
        }

      if(quantidade == -1) {
        VoltarListagemProduto();
      }else{
        _CarrinhoController.AdicionarCarrinho(UsuarioConsumidor, this._itemEstoque.Produto, quantidade, envio);
      }
    }
    
  }
}
