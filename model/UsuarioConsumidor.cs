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

      private List<Venda> vendas;
      public List<Venda> Vendas
      {
          get { return vendas; }
          set { vendas = value; }
      }
      
      

      
      public UsuarioConsumidor(int cpf,string nome, string login, string senha):base(nome,login,senha){
        this.cpf = cpf;
      }
  }
}