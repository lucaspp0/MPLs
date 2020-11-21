
using System;

using MPL.model;
using MPL.repository;
using MPL.controller;
using static MPL.utils.ViewUtils;
using MPL.repository.impl;

namespace MPL.utils
{
  public class Injector
  {
      // repositories
      public static IUserRepository IUserRepository;
      public static IUserEmpreendedorRepository IUserEmpreendedorRepository;
      public static ITransportadorRepository ITransportadorRepository;

      // Controllers
      public static ClientController ClientController;
      public static ClienteConsumidorController  ClienteConsumidorController;
      public static ClienteEmpreenderController  ClienteEmpreenderController;

      public static void initialize(){
            
        IUserRepository = new UserRepositoryImpl(DataBaseGod._DATABASE.UsuarioConsumidor);
        ITransportadorRepository = new TransportRepositoryImpl(DataBaseGod._DATABASE.ContaTransportador);
        IUserEmpreendedorRepository = new EmpreenderRepositoryImpl(DataBaseGod._DATABASE.UsuarioEmpreender);

        ClientController = new ClientController(IUserRepository, ITransportadorRepository, IUserEmpreendedorRepository);        
        ClienteEmpreenderController = new ClienteEmpreenderController(IUserEmpreendedorRepository);
        ClienteConsumidorController = new ClienteConsumidorController(IUserRepository);
      }
  }
}