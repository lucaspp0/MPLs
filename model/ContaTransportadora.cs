using System;
using System.Collections.Generic;
namespace MPL.model
{
  class ContaTransportadora : Pessoa
  {
     
      private List<Venda> vendas;
      public List<Venda> Vendas
      {
          get { return vendas; }
          set { vendas = value; }
      }
      

      public ContaTransportadora(string nome, string login, string senha):base(nome,login,senha){
      }
  }
}