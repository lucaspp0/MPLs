using System.Collections.Generic;


using System;
using MPL.View;
using MPL.model;
using MPL.repository;

using System.Linq;


namespace MPL.controller
{
    public class ClienteEmpreenderController
    {
        IUserEmpreendedorRepository _IUserEmpreendedorRepository;


        public bool Salvar(UsuarioEmpreendedor usuarioEmpreendedor) => this._IUserEmpreendedorRepository.save(usuarioEmpreendedor);

        public ClienteEmpreenderController(IUserEmpreendedorRepository IUserEmpreendedorRepository)
        {
            _IUserEmpreendedorRepository = IUserEmpreendedorRepository;
        }

        public void SelecionarProduto(int idProduto)
        {
            List<UsuarioEmpreendedor> usuarioEmpreenderList = (_IUserEmpreendedorRepository.selectAll());
        }

        public bool RegisterClienteEmpreende(string nome, string login, string senha, string cnpj)
        {
            bool statusSave;

            UsuarioEmpreendedor user = new UsuarioEmpreendedor();
            user.Cnpj = cnpj;
            user.Login = login;
            user.Senha = senha;
            user.Nome = nome;

            Pessoa validEmpreender = FilterUser((_IUserEmpreendedorRepository.selectAll()).Select(x => (Pessoa)x).ToList(), senha, login);

             if(validEmpreender != null) 
                statusSave = false;    
            else 
                statusSave = _IUserEmpreendedorRepository.save(user);
                
            return statusSave;
        }

        public void AcrescentarQtde(int quantidade,int index)
        {
            UsuarioEmpreendedor usuarioLogado = (MainViewManager.CurrentUser as UsuarioEmpreendedor);
            usuarioLogado.Estoque[index].Quantidade += quantidade;
            Salvar(usuarioLogado);
        }

        private Pessoa FilterUser(List<Pessoa> pessoas, string senha, string login)
        {
            return pessoas
                .Where(usuarioEmpreendedor => usuarioEmpreendedor.Senha == senha && usuarioEmpreendedor.Login == login)
                .FirstOrDefault();
        }


    }
}
