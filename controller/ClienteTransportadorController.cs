using System.Collections.Generic;


using System;
using MPL.View;
using MPL.model;
using MPL.repository;

namespace MPL.controller
{
  public class ClienteTransportadorController
  {
    
    IContaTransportadoraRepository _IContaTransportadoraRepository;
    public bool Salvar(ContaTransportadora contaTransportadora) => this._IContaTransportadoraRepository.save(contaTransportadora);

    public ClienteTransportadorController(IContaTransportadoraRepository IContaTransportadora)
    {
      _IContaTransportadoraRepository = IContaTransportadora;
    }
    
    public bool RegisterClienteTransportador(string nome, string login, string senha)
    {
      ContaTransportadora user = new ContaTransportadora(nome, login, senha);
      return _IContaTransportadoraRepository.save(user);
    }
  }
}
