
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
      public static ClientController ClientController;

      public static void initialize(){
        IUserRepository = new UserRepositoryImpl(DataBaseGod._DATABASE.UsuarioConsumidor);
        TransportRepositoryImpl = new TransportRepositoryImpl(DataBaseGod._DATABASE.ContaTransportador);
        EmpreenderRepositoryImpl = new EmpreenderRepositoryImpl(DataBaseGod._DATABASE.UsuarioEmpreender);
        ClientController = new ClientController(IUserRepository,TransportRepositoryImpl ,EmpreenderRepositoryImpl);
        
      }
      
  }
}