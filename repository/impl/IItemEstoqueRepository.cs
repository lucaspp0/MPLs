using System.Collections.Generic;
using MPL.model;

namespace MPL.repository.impl
{
  public class ItemEstoqueRepositoryImpl : BaseRepository<ItemEstoque> , IItemEstoqueRepository
  {
      public ItemEstoqueRepositoryImpl(List<ItemEstoque> ListObj) : base(ListObj){
      
      }

  }

}
