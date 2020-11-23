using System;

using MPL.View;
using MPL.model;
using MPL.repository;
using System.Linq;

namespace MPL.controller
{
  public class ProdutoController
  {
    private IProdutoRepository _IProdutoRepository;

    public bool Salvar(Produto produto) => _IProdutoRepository.save(produto);

    public ProdutoController(IProdutoRepository IProdutoRepository)
    {
      this._IProdutoRepository = IProdutoRepository;
    }
  }
}
