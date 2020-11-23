using System.Collections.Generic;
namespace MPL.model
{
  public class Venda : ABaseModel
  {
      private UsuarioConsumidor usuarioConsumidor;
      public UsuarioConsumidor UsuarioConsumidory
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
      
      public Venda(UsuarioConsumidor usuarioConsumidor, string endereco){
          this.endereco = endereco;
          this.UsuarioConsumidory = usuarioConsumidor;
      }
      public Venda(UsuarioConsumidor usuarioConsumidor){
          this.UsuarioConsumidory = usuarioConsumidor;
      }
      
  }
}
