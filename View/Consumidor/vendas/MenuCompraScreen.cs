using System;

using static MPL.utils.ViewUtils;
using MPL.utils;
using MPL.View.interfaces;
using MPL.repository;
using MPL.model;

using System.Collections.Generic;
using System.Linq;

namespace MPL.View.Consumidor.vendas
{
  public class MenuCompraScreen : IScreen
  {
    private IItemEstoqueRepository _IItemEstoqueRepository;
    
    public MenuCompraScreen(){
      _IItemEstoqueRepository = Injector.IItemEstoqueRepository;
    }

    public void Show()
    {
      List<Produto> produtos =  _IItemEstoqueRepository.selectAll()
                                  .FindAll( x => x.Quantidade > 0)
                                  .Select( x => x.Produto ).ToList();

      string result = GetInput("selecione um produto para detalhar ou -1 parar sair");
      if(result == "-1") MainViewManager.ChangeScreen( new MenuConsumidorScreen() );
    }
  }
}
