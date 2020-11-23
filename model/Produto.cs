namespace MPL.model
{
  public class Produto : ABaseModel
  {
      private string nome;
      public string Nome
      {
          get { return nome; }
          set { nome = value; }
      }
      
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
      public Produto(string nome,float peso, float valor, string categoria){
          this.nome = nome;
          this.peso = peso;
          this.valor = valor;
          this.categoria = categoria;
      }

    public override string ToString()
    {
        return $@"
            Id: {this.Id}
            Nome: {this.nome}
            peso: {this.peso}
            valor: {this.valor}
            categoria: {this.categoria}
          ";
    }
  }
}
