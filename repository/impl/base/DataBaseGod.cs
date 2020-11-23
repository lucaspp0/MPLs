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
    private List<ItemEstoque> itemEstoque = new List<ItemEstoque>();
    public List<ItemEstoque> ItemEstoque { 
      get { return itemEstoque; } 
      set { itemEstoque = value; } 
    }
    
    private List<Venda> venda = new List<Venda>();
    public List<Venda> Venda { 
      get { return venda; } 
      set { venda = value; } 
    }

    private List<ItemVenda> itemVenda = new List<ItemVenda>();
    public List<ItemVenda> ItemVenda { 
      get { return itemVenda; } 
      set { itemVenda = value; } 
    }
  }

}
