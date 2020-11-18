
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


      public static TransportRepositoryImpl TransportRepositoryImpl;
      public static EmpreenderRepositoryImpl EmpreenderRepositoryImpl;

      // Controllers
      //public static LoginController LoginController;
      public static ClientController ClientController;
      public static ClienteConsumidorController  ClienteConsumidorController;
      public static ClienteEmpreenderController  ClienteEmpreenderController;

      public static void initialize(){
        ClienteEmpreenderController ClienteEmpreenderController = new ClienteEmpreenderController(IUserEmpreendedorRepository);
        ClienteConsumidorController ClienteConsumidorController = new ClienteConsumidorController(IUserRepository);
        ClientController ClientController = new ClientController(IUserRepository,ITransportadorRepository,IUserEmpreendedorRepository);

        IUserRepository = new UserRepositoryImpl(DataBaseGod._DATABASE.UsuarioConsumidor);
        TransportRepositoryImpl = new TransportRepositoryImpl(DataBaseGod._DATABASE.ContaTransportador);
        EmpreenderRepositoryImpl = new EmpreenderRepositoryImpl(DataBaseGod._DATABASE.UsuarioEmpreender);
        ClientController = new ClientController(IUserRepository,TransportRepositoryImpl ,EmpreenderRepositoryImpl);

        
      }
      
  }
}