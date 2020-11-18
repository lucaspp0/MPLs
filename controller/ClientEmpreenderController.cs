using System.Collections.Generic;


using System;
using MPL.View;
using MPL.model;
using MPL.repository;
using System.Threading.Tasks;

namespace MPL.controller
{
     public class ClienteEmpreenderController
    {
        IUserEmpreendedorRepository _IUserEmpreendedorRepository;

        public ClienteEmpreenderController(IUserEmpreendedorRepository IUserEmpreendedorRepository)
        {
            _IUserEmpreendedorRepository = IUserEmpreendedorRepository;

        }

        public async Task SelecionarProduto(int idProduto)
        {

            List<UsuarioEmpreendedor> usuarioEmpreenderList = (await _IUserEmpreendedorRepository.selectAll());

        
        }

        public async Task<bool> RegisterClienteEmpreende(string nome,string login,string senha,string cnpj){
           UsuarioEmpreendedor user = new UsuarioEmpreendedor();
           user.Cnpj = cnpj;
           user.Login = login;
           user.Senha = senha;
           user.Nome = nome;
            
           bool statusSave = await _IUserEmpreendedorRepository.save(user);
            
            return statusSave;
        } 

    }
}