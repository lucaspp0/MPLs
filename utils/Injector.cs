
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
      public static IUserConsumidorRepository IUserConsumidorRepository;
      public static IItemEstoqueRepository IItemEstoqueRepository;

      // Controllers
      public static ClientController ClientController;
      public static ClienteConsumidorController  ClienteConsumidorController;
      public static ClienteEmpreenderController  ClienteEmpreenderController;

      public static void initialize(){
            
        IUserRepository = new UserRepositoryImpl(DataBaseGod._DATABASE.UsuarioConsumidor);
        ITransportadorRepository = new TransportRepositoryImpl(DataBaseGod._DATABASE.ContaTransportador);
        IUserEmpreendedorRepository = new EmpreenderRepositoryImpl(DataBaseGod._DATABASE.UsuarioEmpreender);
        IUserConsumidorRepository = new UserConsumidorRepositoryImpl(DataBaseGod._DATABASE.UsuarioConsumidor);
        IItemEstoqueRepository = new ItemEstoqueRepositoryImpl(DataBaseGod._DATABASE.ItemEstoque);

        ClientController = new ClientController(IUserRepository, ITransportadorRepository, IUserEmpreendedorRepository);        
        ClienteEmpreenderController = new ClienteEmpreenderController(IUserEmpreendedorRepository);
        ClienteConsumidorController = new ClienteConsumidorController(IUserRepository);
      }
  }
}
