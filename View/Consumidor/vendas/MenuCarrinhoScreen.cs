using System;

using static MPL.utils.ViewUtils;
using MPL.View.interfaces;
using MPL.model;
using MPL.utils;

namespace MPL.View.Consumidor.vendas
{
  public class MenuCarrinhoScreen : IScreen
  {

    public void VoltarMenuConsumidor() => 
      MainViewManager.ChangeScreen( new MenuConsumidorScreen() );

    public void Show()
    {
      Venda venda = null;
      ShowScreen("Mostrar Todos Itens");
      UsuarioConsumidor usuarioConsumidor = MainViewManager.CurrentUser as UsuarioConsumidor;

      if(!Injector.CarrinhoController.ExisteCarrinho(usuarioConsumidor)){
        ShowScreen("Nenhum produto encontrado no carrinho");
        GetWaitingInput();
        VoltarMenuConsumidor();
        return;
      }else{
        venda = Injector.CarrinhoController.Getcarrinho(usuarioConsumidor);
        if(venda.ItemVendas.Count == 0){
          ShowScreen("Nenhum produto encontrado no carrinho");
          GetWaitingInput();
          VoltarMenuConsumidor();
        }
      }

      string result = GetInput($@"
      1 - Finalizar Compra
      2 - Remover Produto
      3 - Sair

Digite a opção: ");
      
      if(result == "1"){

        if(Injector.CarrinhoController.ExisteCarrinho(usuarioConsumidor)){

          if( Injector.VendaController.FinalizarVenda(venda) )
            ShowScreen("Venda realizada com sucesso"); 
          else ShowScreen("Ocorreu um erro ao realizar a venda");

          GetWaitingInput();

        }else{
          ShowScreen("Carrinho Vázio");
        }

        GetWaitingInput();

      }else if(result == "2"){

        int id = GetInputInt("Selecione o id do produto: ");

        if(venda.ItemVendas.RemoveAll( x => x.Produto.Id == id ) > 0){

          Injector.VendaController.RemoverItemVenda(id);
          Injector.VendaController.SalvarVenda(venda);
          ShowScreen("Produto removido com sucesso");
  
        }else{
          ShowScreen("Não existe produto com esse ID");
        }

        GetWaitingInput();

      }else if(result == "3"){
        VoltarMenuConsumidor();
      }else{
        ShowScreen("Escolha inválida");
        GetWaitingInput();
      }

    }
  }
}
