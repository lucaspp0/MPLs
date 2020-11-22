using System.Collections.Generic;
namespace MPL.model
{
  public class ContaTransportadora : Pessoa
  {
       private List<Venda> vendas;
       public List<Venda> Vendas
      {
          get { return vendas; }
          set { vendas = value; }
      }
      

      public ContaTransportadora(string nome, string login, string senha){
          this.nome = nome;
          this.login = login;
          this.senha = senha;

      }
      
  }
}