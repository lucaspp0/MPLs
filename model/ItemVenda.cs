namespace MPL.model
{
  public class ItemVenda : ABaseModel
  {
      private float frete;
      public float Frete
      {
          get { return frete; }
          set { frete = value; }
      }

      private Produto produto;
      public Produto Produto
      {
          get { return produto; }
          set { produto = value; }
      }
      
      private string status;
      public string Status
      {
          get { return status; }
          set { status = value; }
      }
      private int quantidade;
      public int Quantidade
      {
          get { return quantidade; }
          set { quantidade = value; }
      }
      private Envio envio;
      public Envio Envio
      {
          get { return envio; }
          set { envio = value; }
      }
      public ItemVenda(){}
      public ItemVenda(Produto produto, int Quantidade, Envio Envio){
          this.status = "Pendente";
          this.Envio = Envio;
          this.Frete = this.Envio.CalcularFrete(produto.Valor);
      }

      public ItemVenda(float frete, string status, int quantidade, Envio envio){
          this.frete = frete;
          this.status = status;
          this.quantidade = quantidade;
          this.envio = envio;
      }
  }
}
