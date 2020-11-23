using System.Collections.Generic;


using System;
using MPL.View;
using MPL.model;
using MPL.repository;
using System.Linq;

namespace MPL.controller
{
  public class ItemEstoqueController
  {
    private IItemEstoqueRepository _IItemEstoqueRepository;
    public ItemEstoqueController(IItemEstoqueRepository IItemEstoqueRepository)
    {
      this._IItemEstoqueRepository = IItemEstoqueRepository;
    }

    public ItemEstoque BuscarPorProduto(Produto produto)
      => this._IItemEstoqueRepository.selectAll().Where(x => x.Produto.Id == produto.Id).FirstOrDefault();

  }
}
