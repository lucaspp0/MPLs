using System.Collections.Generic;

using System;
using MPL.View;
using MPL.utils;
using static MPL.utils.ViewUtils;
using MPL.model;
using MPL.repository;

using System.Linq;

namespace MPL.controller
{
  public class ClientController
  {
    IUserRepository _IUserRepository;
    IUserEmpreendedorRepository _IUserEmpreendedorRepository;

    IContaTransportadoraRepository _ITransportadorRepository;
    private IVendaRepository _IVendaRepository;
    private IItemVendaRepository _IItemVendaRepository;

    public ClientController(IUserRepository IUserRepository, IContaTransportadoraRepository ITransportadorRepository, IUserEmpreendedorRepository IUserEmpreendedorRepository,IVendaRepository IVendaRepository, IItemVendaRepository IItemVendaRepos)
    {
      _IUserRepository = IUserRepository;
      _IUserEmpreendedorRepository = IUserEmpreendedorRepository;
      _ITransportadorRepository = ITransportadorRepository;
      _IItemVendaRepository = IItemVendaRepos;
      _IVendaRepository = IVendaRepository;

    }

    private Pessoa FilterUser(List<Pessoa> pessoas, string senha, string login)
    {
      return pessoas
        .Where(usuarioConsumidor => usuarioConsumidor.Senha == senha && usuarioConsumidor.Login == login)
        .FirstOrDefault();
    }

    public  bool Login(string login, string senha)
    {
      Pessoa usuarioConsumidor = FilterUser((_IUserRepository.selectAll()).Select(x => (Pessoa)x).ToList(), senha, login);

      Pessoa usuarioEmpreendedor = FilterUser((_IUserEmpreendedorRepository.selectAll()).Select(x => (Pessoa)x).ToList(), senha, login);

      Pessoa usuarioTransportador = FilterUser((_ITransportadorRepository.selectAll()).Select(x => (Pessoa)x).ToList(), senha, login);

      List<Pessoa> listaPessoas = new List<Pessoa>() { usuarioConsumidor, usuarioEmpreendedor, usuarioTransportador };

      Pessoa pessoaEncontrada = listaPessoas
        .Where(pessoa => pessoa != null)
        .FirstOrDefault();

      MainViewManager.CurrentUser = pessoaEncontrada;
      return pessoaEncontrada != null;
    }

    public List<Venda> returnBuyProducts(){      
      List<Venda> list = _IVendaRepository.GetVendas(MainViewManager.CurrentUser as UsuarioConsumidor);

      return list;
    }
  }

}
