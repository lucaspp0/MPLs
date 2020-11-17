using System.Collections.Generic;
using MPL.model;

namespace MPL.repository.impl
{
  public class TransportRepositoryImpl : BaseRepository<ContaTransportador> , ITransportadorRepository
  {
      public TransportRepositoryImpl(List<ContaTransportador> ListObj) : base(ListObj){
      
      }

  }

}