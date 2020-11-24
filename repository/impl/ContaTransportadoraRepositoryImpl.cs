using System.Collections.Generic;
using MPL.model;

namespace MPL.repository.impl
{
  public class ContaTransportadoraRepositoryImpl : BaseRepository<ContaTransportadora>, IContaTransportadoraRepository
  {
      public ContaTransportadoraRepositoryImpl(List<ContaTransportadora> ListObj) : base(ListObj){
        
      
      }

  }

}
