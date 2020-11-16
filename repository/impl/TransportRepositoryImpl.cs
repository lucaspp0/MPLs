using System.Collections.Generic;
using MPL.model;

namespace MPL.repository.impl
{
  public class TransportRepositoryImpl : BaseRepository<TransportadorPrivada>, IUserRepository
  {
      public UserRepositoryImpl(List<TransportadorPrivada> ListObj) : base(ListObj){
        
      }

  }

}