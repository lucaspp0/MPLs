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
      
  }
}