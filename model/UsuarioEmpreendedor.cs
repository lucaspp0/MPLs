using System;
namespace MPL.model
{
  public class UsuarioEmpreendedor : Pessoa
  {
      private string cnpj;
      public string Cnpj
      {
          get { return cnpj; }
          set { cnpj = value; }
      }
      
      private DateTime tempo_cadastro;
      public DateTime Tempo_Cadastro
      {
          get { return tempo_cadastro; }
          set { tempo_cadastro = value; }
      }
      
  }
}