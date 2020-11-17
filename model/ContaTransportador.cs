namespace MPL.model
{
  public class ContaTransportador : Pessoa
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
      
  }
}