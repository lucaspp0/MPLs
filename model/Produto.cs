namespace MPL.model
{
  class Produto
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
  }
}