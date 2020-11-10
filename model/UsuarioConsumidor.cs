using System;
using System.Collections.Generic;
namespace MPL.model
{
  class UsuarioConsumidor : Pessoa
  {
      private int cpf;
      public int Cpf
      {
          get { return cpf; }
          set { cpf = value; }
      }
      
      public UsuarioConsumidor(int cpf,string nome, string login, string senha):base(nome,login,senha){
        this.cpf = cpf;
      }
  }
}