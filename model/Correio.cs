namespace MPL.model
{
    public class Correio : ABaseModel
  {
      private bool documento;
      public bool Documento
      {
          get { return documento; }
          set { documento = value; }
      }
      public Correio(bool documento, float valorFreteGratis):base(valorFreteGratis){
          this.documento = documento;
      }
      
  }
}