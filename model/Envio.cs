namespace MPL.model
{
  public abstract class Envio : ABaseModel
  {
      private float valorFreteGratis;
      public float ValorFreteGratis
      {
          get { return valorFreteGratis; }
          set { valorFreteGratis = value; }
      }
      public Envio(float valorFreteGratis){
        this.valorFreteGratis = valorFreteGratis;
      }
      
  }
}
