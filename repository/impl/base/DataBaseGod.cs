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

    private List<ContaTransportadora> contaTransportador = new List<ContaTransportadora>();
    public List<ContaTransportadora> ContaTransportador { 
      get { return contaTransportador; } 
      set { contaTransportador = value; } 
    }

    private List<UsuarioEmpreendedor> usuarioEmpreender = new List<UsuarioEmpreendedor>();
    public List<UsuarioEmpreendedor> UsuarioEmpreender { 
      get { return usuarioEmpreender; } 
      set { usuarioEmpreender = value; } 
    }

  }

}
