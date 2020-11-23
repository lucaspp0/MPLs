using System.Collections.Generic;
using MPL.model;

namespace MPL.repository.impl
{
  public class ItemVendaRepositoryImpl : BaseRepository<ItemVenda>, IItemVendaRepository
  {
      public ItemVendaRepositoryImpl(List<ItemVenda> ListObj) : base(ListObj){
      
      }

  }

}
