using System.Collections.Generic;
using MPL.model;

namespace MPL.repository.impl
{
  public class TransportRepositoryImpl : BaseRepository<ContaTransportadora> , ITransportadorRepository
  {
      public TransportRepositoryImpl(List<ContaTransportadora> ListObj) : base(ListObj){
      
      }

  }

}
