using System.Collections.Generic;
using MPL.model;

namespace MPL.repository.impl
{
  public class DataBaseGod
  {
    private static DataBaseGod _DataBase;
    

    private static void InitializeBd(DataBaseGod dataBase){
      dataBase = new DataBaseGod();
      dataBase.UsuarioConsumidor = new List<UsuarioConsumidor>();
    }
    
    public static DataBaseGod _DATABASE
    {
        get { 
          if(_DataBase == null) InitializeBd(_DataBase);
          return _DataBase;
        }
        set{ _DataBase = value; }
    }
    
    List<UsuarioConsumidor> usuarioConsumidor = new List<UsuarioConsumidor>();
    public List<UsuarioConsumidor> UsuarioConsumidor { 
      get { return usuarioConsumidor; } 
      set { usuarioConsumidor = value; } 
    }
    
  }

}