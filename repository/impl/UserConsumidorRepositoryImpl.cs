using System.Collections.Generic;
using MPL.model;

namespace MPL.repository.impl
{
  public class UserConsumidorRepositoryImpl : BaseRepository<UsuarioConsumidor>, IUserConsumidorRepository
  {
      public UserConsumidorRepositoryImpl(List<UsuarioConsumidor> ListObj) : base(ListObj){
      
      }

  }

}
