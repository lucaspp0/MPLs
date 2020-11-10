namespace MPL.model
{
    class Correio : Envio
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