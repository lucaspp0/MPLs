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
      
  }
}