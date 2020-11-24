using System.Collections.Generic;
using MPL.model;

namespace MPL.repository.impl
{
  public class UserRepositoryImpl : BaseRepository<UsuarioConsumidor>, IUserRepository
  {
      public UserRepositoryImpl(List<UsuarioConsumidor> ListObj) : base(ListObj){
        
      }

  }

}
