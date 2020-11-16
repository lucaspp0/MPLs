
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

      // Controllers
      public static LoginController LoginController;

      public static void initialize(){
        Console.WriteLine("antes initi");
        IUserRepository = new UserRepositoryImpl(DataBaseGod._DATABASE.UsuarioConsumidor);
        Console.WriteLine("meio initi");
        IUserRepository = new TransportRepositoryImpl(DataBaseGod._DATABASE.Transported);
        Console.WriteLine("meio initi 2");
        IUserRepository = new EmpreenderRepositoryImpl(DataBaseGod._DATABASE.UsuarioEmpreender);
        Console.WriteLine("meio initi 3");
        LoginController = new LoginController(IUserRepository);
        Console.WriteLine("final initi");
      }
      
  }
}