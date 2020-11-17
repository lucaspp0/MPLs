using System.Collections.Generic;
using MPL.model;

namespace MPL.repository.impl
{
  public class EmpreenderRepositoryImpl : BaseRepository<UsuarioEmpreendedor>, IUserEmpreendedorRepository
  {
      public EmpreenderRepositoryImpl(List<UsuarioEmpreendedor> ListObj) : base(ListObj){
        
      
      }

  }

}