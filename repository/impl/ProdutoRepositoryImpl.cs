using System.Collections.Generic;
using MPL.model;

namespace MPL.repository.impl
{
  public class ProdutoRepositoryImpl : BaseRepository<Produto>, IProdutoRepository
  {
      public ProdutoRepositoryImpl(List<Produto> ListObj) : base(ListObj){
      
      }

  }

}
