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

        public void SelecionarProduto(int idProduto)
        {

            List<UsuarioEmpreendedor> usuarioEmpreenderList = (_IUserEmpreendedorRepository.selectAll());

        
        }

        public  bool RegisterClienteEmpreende(string nome,string login,string senha,string cnpj){
           UsuarioEmpreendedor user = new UsuarioEmpreendedor();
           user.Cnpj = cnpj;
           user.Login = login;
           user.Senha = senha;
           user.Nome = nome;
            
           bool statusSave = _IUserEmpreendedorRepository.save(user);
            
            return statusSave;
        } 

        public void CadastrarProdutoEstoque(string nome,float peso, float valor,string categoria,int estoqueQtde,string endereco){
            Produto produto = new Produto(nome,peso,valor,categoria);

        }

    }
}
