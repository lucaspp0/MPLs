namespace MPL.model
{
  abstract class Envio : ABaseModel
  {
      //Declaração e métodos get/set
      private float valorFreteGratis;
      public float ValorFreteGratis
      {
          get { return valorFreteGratis; }
          set { valorFreteGratis = value; }
      }
      //Construtor
      public Envio(float valorFreteGratis){
        this.valorFreteGratis = valorFreteGratis;
      }
  }
}