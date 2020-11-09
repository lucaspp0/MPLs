using System.Collections.Generic;
using MPL.model;

namespace MPL.repository.impl
{
  class DataBaseGod
  {
    List<Usuario> usuario = new List<Usuario>();
    public List<Usuario> Usuario { 
      get { return usuario; } 
      set { usuario = value; } 
    }
    
  }

}