using System.Collections.Generic;

using System;
using MPL.View;
using MPL.model;
using MPL.repository;
using System.Threading.Tasks;
using System.Linq;

namespace MPL.controller
{
  public class ClientController
  {
    IUserRepository _IUserRepository;
    IUserEmpreendedorRepository _IUserEmpreendedorRepository;
    ITransportadorRepository _ITransportadorRepository;

    public ClientController(IUserRepository IUserRepository, ITransportadorRepository ITransportadorRepository, IUserEmpreendedorRepository IUserEmpreendedorRepository)
    {
      _IUserRepository = IUserRepository;
      _IUserEmpreendedorRepository = IUserEmpreendedorRepository;
      _ITransportadorRepository = ITransportadorRepository;

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
  }

}
