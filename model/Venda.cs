using System.Collections.Generic;
namespace MPL.model
{
  class Venda : ABaseModel
  {
      private string status;
      public string Status
      {
          get { return status; }
          set { status = value; }
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
      
      
      public Venda(string status,string endereco){
          this.status = status;
          this.endereco = endereco;
      }
  }
}