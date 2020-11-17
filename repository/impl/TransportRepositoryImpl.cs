using System.Collections.Generic;
using MPL.model;

namespace MPL.repository.impl
{
  public class TransportRepositoryImpl : BaseRepository<TransportadorPrivada>
  {
      public TransportRepositoryImpl(List<TransportadorPrivada> ListObj) : base(ListObj){
      
      }

  }

}