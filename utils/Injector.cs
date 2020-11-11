using System.Linq;

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
        IUserRepository = new UserRepositoryImpl(BaseRepository<UsuarioConsumidor>._DATABASE.UsuarioConsumidor);
        LoginController = new LoginController(IUserRepository);
      }
      
  }
}