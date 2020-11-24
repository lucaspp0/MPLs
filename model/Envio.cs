namespace MPL.model
{
  public class Envio : ABaseModel
  {
      private float valorFreteGratis;
      public float ValorFreteGratis
      {
          get { return valorFreteGratis; }
          set { valorFreteGratis = value; }
      }
      
      public Envio(){ }

      public Envio(float valorFreteGratis){
        this.valorFreteGratis = valorFreteGratis;
      }
      
      public virtual float CalcularFrete(float ValorProduto){
        if(ValorProduto <= ValorFreteGratis) return 0;
        return 10;
      }

  }
}
