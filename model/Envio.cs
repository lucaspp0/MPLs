namespace MPL.model
{
  abstract class Envio : ABaseModel
  {
      private float valorFreteGratis;
      public float ValorFreteGratis
      {
          get { return valorFreteGratis; }
          set { valorFreteGratis = value; }
      }
      
  }
}