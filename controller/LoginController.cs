using System.Collections.Generic;

using MPL.View;
using MPL.model;
using MPL.repository;


namespace MPL.controller
{
  public class LoginController
  {
      IUserRepository _IUserRepository;
      public LoginController(IUserRepository IUserRepository ){
        _IUserRepository = IUserRepository;
      }

      public  bool DoLogin(string login, string senha){
        List<UsuarioConsumidor> usuarioEncontrado = (_IUserRepository.selectAll());
        for (int i = 0; i < usuarioEncontrado.Count; i++)
        {
            if(usuarioEncontrado[i].Senha == senha && usuarioEncontrado[i].Login == login){
              MainViewManager.CurrentUser = usuarioEncontrado[i];
              return true;
            }
        }
        return false;
      }
  }
}
