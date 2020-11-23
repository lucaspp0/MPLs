using System;
using System.Collections.Generic;
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
      private List<ItemEstoque> estoque;
      public List<ItemEstoque> Estoque
      {
          get { return estoque; }
          set { estoque = value; }
      }
      
      public UsuarioEmpreendedor(){
        this.Estoque = new List<ItemEstoque>();
      }

      public void ArmazenarNoEstoque(ItemEstoque item){
        this.Estoque.Add(item);
      }

      public UsuarioEmpreendedor(string cnpj,string nome, string login, string senha){
        this.cnpj = cnpj;
        this.nome = nome;
        this.login = login;
        this.senha = senha;
        this.Estoque = new List<ItemEstoque>();
      }
      
  }
}
