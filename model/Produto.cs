namespace MPL.model
{
  class Produto : ABaseModel
  {
      private float peso;
      public float Peso
      {
          get { return peso; }
          set { peso = value; }
      }
      private float valor;
      public float Valor
      {
          get { return valor; }
          set { valor = value; }
      }
      private string categoria;
      public string Categoria
      {
          get { return categoria; }
          set { categoria = value; }
      }
      public Produto(float peso, float valor, string categoria){
          this.peso = peso;
          this.valor = valor;
          this.categoria = categoria;
      }
  }
}