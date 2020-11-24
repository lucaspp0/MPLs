using System.Collections.Generic;

using System;
using MPL.View;
using MPL.model;
using MPL.repository;

using System.Linq;

namespace MPL.controller
{
    public class ClienteConsumidorController
    {
        IUserRepository _IUserRepository;

        public ClienteConsumidorController(IUserRepository IUserRepository)
        {
            _IUserRepository = IUserRepository;

        }

        public  void SelecionarProduto(int idProduto)
        {

            List<UsuarioConsumidor> usuarioConsumidorList = (_IUserRepository.selectAll());
        
        }

        public  bool RegisterClienteConsumidor(string nome,string login,string senha,string cpf){
           bool statusSave;

           UsuarioConsumidor user = new UsuarioConsumidor();
           user.Cpf = cpf;
           user.Login = login;
           user.Senha = senha;
           user.Nome = nome;
            
            Pessoa userValid = FilterUser((_IUserRepository.selectAll()).Select(x => (Pessoa)x).ToList(), senha, login);

            if(userValid != null) 
                statusSave = false;    
            else 
                statusSave = _IUserRepository.save(user);
            
            
            return statusSave;
        } 

    private Pessoa FilterUser(List<Pessoa> pessoas, string senha, string login)
    {
      return pessoas
        .Where(usuarioConsumidor => usuarioConsumidor.Senha == senha && usuarioConsumidor.Login == login)
        .FirstOrDefault();
    }


           
    }
}
