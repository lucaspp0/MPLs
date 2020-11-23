using System.Linq;
using System.Collections.Generic;

using MPL.utils;
using MPL.model;
using MPL.View.interfaces;
using MPL.repository;
using static MPL.utils.ViewUtils;
namespace MPL.View.Consumidor.vendas
{
  public class MenuCompraScreen : IScreen
  {
    private IItemEstoqueRepository _IItemEstoqueRepository;
    
    public MenuCompraScreen(){
      _IItemEstoqueRepository = Injector.IItemEstoqueRepository;
    }

    private bool PesquisarProduto(Produto produto, string pesquisa){
      pesquisa = pesquisa.Trim().ToLower();

      return produto.Categoria.Trim().ToLower().Contains(pesquisa)
             || produto.Nome.Trim().ToLower().Contains(pesquisa)
             || produto.Id.ToString() == pesquisa;
    }

    private void VoltarTelaConsumidor() => MainViewManager.ChangeScreen( new MenuConsumidorScreen() );

    public void Show()
    {
      string result = GetInput("digite a categoria ou o nome do produto: ").Trim().ToLower();
      List<Produto> produtos =  _IItemEstoqueRepository.selectAll()
                                  .FindAll( x => x.Quantidade > 0 && PesquisarProduto(x.Produto, result) )
                                  .Select( x => x.Produto ).ToList();
                                  
      produtos.ForEach(x => ShowScreen( $"{x.Id} - {x.Nome}" ) );
      result = GetInput("selecione o Id do produto para detalhar ou -1 parar sair");

      if(result == "-1") VoltarTelaConsumidor();

      if(int.TryParse(result, out int IdSelecionado)){
        Produto produtoSelecianado = produtos.FindAll();
      } else {
        ShowScreen("Formato de Id incorreto");
        GetWaitingInput();
        VoltarTelaConsumidor();
      }

    }
  }
}
