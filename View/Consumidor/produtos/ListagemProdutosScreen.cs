using System.Linq;
using System.Collections.Generic;

using MPL.utils;
using MPL.model;
using MPL.View.interfaces;
using MPL.repository;
using static MPL.utils.ViewUtils;
using MPL.View.Consumidor.produtos;

namespace MPL.View.Consumidor.produtos
{
  public class ListagemProdutosScreen : IScreen
  {
    
    private IItemEstoqueRepository _IItemEstoqueRepository;
    
    public ListagemProdutosScreen(){
      _IItemEstoqueRepository = Injector.IItemEstoqueRepository;
    }

    private bool PesquisarProduto(Produto produto, string pesquisa){
      pesquisa = pesquisa.Trim().ToLower();

      return produto.Categoria.Trim().ToLower().Contains(pesquisa)
             || produto.Nome.Trim().ToLower().Contains(pesquisa)
             || produto.Id.ToString() == pesquisa;
    }

    private void VoltarTelaConsumidor() => MainViewManager.ChangeScreen( new MenuConsumidorScreen() );


    public  void Show()
    {
      string result = GetInput("digite a categoria ou o nome do produto: ").Trim().ToLower();
      List<ItemEstoque> produtos =  _IItemEstoqueRepository.selectAll()
                                  .FindAll( x => x.Quantidade > 0 && PesquisarProduto(x.Produto, result) )
                                  .ToList();
                                  
      produtos.ForEach(x => ShowScreen( $"{x.Produto.Id} - {x.Produto.Nome}" ) );
      int id = GetInputInt("selecione o Id do produto para detalhar ou -1 parar sair: ");

      if(id <= -1) VoltarTelaConsumidor();
      
      ItemEstoque produtoSelecionado = produtos.Where(x => x.Id == id).FirstOrDefault();

      if(produtoSelecionado != null) {
        MainViewManager.ChangeScreen(new DetalheProdutoScreen(produtoSelecionado));
      }
      else{
        ShowScreen("produto não encontrado");
        GetWaitingInput();
        VoltarTelaConsumidor();
      }
    }
  }
}
