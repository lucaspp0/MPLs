namespace MPL.model
{
  public class UsuarioConsumidor : Pessoa
  {
      private string cpf;
      public string Cpf
      {
          get { return cpf; }
          set { cpf = value; }
      }
      
      public UsuarioConsumidor(){}
      public UsuarioConsumidor(string cpf,string nome, string login, string senha){
        this.cpf = cpf;
        this.nome = nome;
        this.login = login;
        this.senha = senha;
      }
      
  }
}
