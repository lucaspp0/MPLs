using System.Collections.Generic;
using MPL.model;

namespace MPL.repository.impl
{
  public class EmpreenderRepositoryImpl : BaseRepository<UsuarioEmpreendedor>, IUserRepository
  {
      public UserRepositoryImpl(List<UsuarioEmpreendedor> ListObj) : base(ListObj){
        
      }

  }

}