using System.Collections.Generic;
using MPL.model;

namespace MPL.repository.impl
{
  public class DataBaseGod
  {
    List<UsuarioConsumidor> usuarioConsumidor = new List<UsuarioConsumidor>();
    public List<UsuarioConsumidor> UsuarioConsumidor { 
      get { return usuarioConsumidor; } 
      set { usuarioConsumidor = value; } 
    }
    
  }

}