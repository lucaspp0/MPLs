
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

      public static TransportRepositoryImpl TransportRepositoryImpl;
      public static EmpreenderRepositoryImpl EmpreenderRepositoryImpl;

      // Controllers
      //public static LoginController LoginController;
      public static ClientController ClientController;

      public static void initialize(){
        Console.WriteLine("antes initi");
        IUserRepository = new UserRepositoryImpl(DataBaseGod._DATABASE.UsuarioConsumidor);
        Console.WriteLine("meio initi");
        TransportRepositoryImpl = new TransportRepositoryImpl(DataBaseGod._DATABASE.ContaTransportador);
        Console.WriteLine("meio initi 2");
        EmpreenderRepositoryImpl = new EmpreenderRepositoryImpl(DataBaseGod._DATABASE.UsuarioEmpreender);
        Console.WriteLine("meio initi 2");
        ClientController = new ClientController(IUserRepository,TransportRepositoryImpl ,EmpreenderRepositoryImpl);
        Console.WriteLine("final initi");
        
      }
      
  }
}