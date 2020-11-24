using System.Collections.Generic;
namespace MPL.model
{
  public class Venda : ABaseModel
  {
      private UsuarioConsumidor usuarioConsumidor;
      public UsuarioConsumidor UsuarioConsumidor
      {
          get { return usuarioConsumidor; }
          set { usuarioConsumidor = value; }
      }
      
      private string endereco;
      public string Endereco
      {
          get { return endereco; }
          set { endereco = value; }
      }
      
      private bool finalizado;
      public bool Finalizado
      {
          get { return finalizado; }
          set { finalizado = value; }
      }
      private List<ItemVenda> itemVendas;
      public List<ItemVenda> ItemVendas
      {
          get { return itemVendas; }
          set { itemVendas = value; }
      }
      
      public Venda(UsuarioConsumidor UsuarioConsumidor, string endereco){
          this.endereco = endereco;
          this.UsuarioConsumidor = UsuarioConsumidor;
      }
      public Venda(){}
      public Venda(UsuarioConsumidor UsuarioConsumidor){
          this.UsuarioConsumidor = UsuarioConsumidor;
      }
      
  }
}
