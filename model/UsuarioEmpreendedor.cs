using System;
namespace MPL.model
{
  class UsuarioEmpreendedor : Pessoa
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
      public UsuarioEmpreendedor(int cnpj,string nome, string login, string senha):base(nome,login,senha){
        this.cnpj = cnpj;
      }
  }
}