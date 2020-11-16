using System.Collections.Generic;
using MPL.model;

namespace MPL.repository.impl
{
  public class DataBaseGod
  {
    private static DataBaseGod _DataBase;
        
    public static DataBaseGod _DATABASE
    {
        get { 
          if(_DataBase == null) _DataBase = new DataBaseGod(); 
          return _DataBase;
        }
        set{ _DataBase = value; }
    }
    
    private List<UsuarioConsumidor> usuarioConsumidor = new List<UsuarioConsumidor>();
    public List<UsuarioConsumidor> UsuarioConsumidor { 
      get { return usuarioConsumidor; } 
      set { usuarioConsumidor = value; } 
    }

    private List<TransportadorPrivada> Transported = new List<TransportadorPrivada>();
    public List<TransportadorPrivada> Transported { 
      get { return Transported; } 
      set { Transported = value; } 
    }

    private List<UsuarioEmpreendedor> UsuarioEmpreender = new List<UsuarioEmpreendedor>();
    public List<UsuarioEmpreendedor> UsuarioEmpreender { 
      get { return UsuarioEmpreender; } 
      set { UsuarioEmpreender = value; } 
    }

  }

}