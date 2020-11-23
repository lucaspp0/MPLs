using System.Collections.Generic;


using System;
using MPL.View;
using MPL.model;
using MPL.repository;

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

        public bool RegisterClienteEmpreende(string nome, string login, string senha, string cnpj)
        {
            UsuarioEmpreendedor user = new UsuarioEmpreendedor();
            user.Cnpj = cnpj;
            user.Login = login;
            user.Senha = senha;
            user.Nome = nome;

            bool statusSave = _IUserEmpreendedorRepository.save(user);

            return statusSave;
        }

        public void AcrescentarQtde(int quantidade,int index)
        {
            UsuarioEmpreendedor usuarioLogado = (MainViewManager.CurrentUser as UsuarioEmpreendedor);
            usuarioLogado.Estoque[index].Quantidade += quantidade;
        }

        public void CadastrarProdutoEstoque(string nome, float peso, float valor, string categoria, int estoqueQtde, string endereco)
        {
            UsuarioEmpreendedor usuarioLogado = (MainViewManager.CurrentUser as UsuarioEmpreendedor);
            Produto produto = new Produto(nome, peso, valor, categoria);
            ItemEstoque itensEstoque = new ItemEstoque(estoqueQtde, produto, endereco);
            usuarioLogado.ArmazenarNoEstoque(itensEstoque);


        }

    }
}
