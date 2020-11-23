namespace MPL.model
{
  public class ItemEstoque : ABaseModel
  {
      private int quantidade;
      public int Quantidade
      {
          get { return quantidade; }
          set { quantidade = value; }
      }
      
      private Produto produto;
      public Produto Produto
      {
          get { return produto; }
          set { produto = value; }
      }
      private string endereco;
      public string Endereco
      {
          get { return endereco; }
          set { endereco = value; }
      }
      public ItemEstoque(int quantidade,Produto produto,string endereco){
          this.Quantidade = quantidade;
          this.Produto = produto;
          this.Endereco = endereco;
      }
            
  }
}
