using System;
namespace MPL.model
{
  class Usuario_Empreendedor : Pessoa
  {
      private int cnpj;
      public int Cnpj
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