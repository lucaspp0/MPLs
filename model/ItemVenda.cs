namespace MPL.model
{
  class ItemVenda : ABaseModel
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
      
      public ItemVenda(float frete, string status, int quantidade){
          this.frete = frete;
          this.status = status;
          this.quantidade = quantidade;
      }
  }
}