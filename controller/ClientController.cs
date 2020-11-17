using System.Collections.Generic;

using System;
using MPL.View;
using MPL.model;
using MPL.repository;
using System.Threading.Tasks;

namespace MPL.controller
{
    public class ClientController
    {
      IUserRepository _IUserRepository;
      IUserEmpreendedorRepository _IUserEmpreendedorRepository;
      
      ITransportadorRepository _ITransportadorRepository;

      public ClientController(IUserRepository IUserRepository,ITransportadorRepository ITransportadorRepository,IUserEmpreendedorRepository IUserEmpreendedorRepository ){
        _IUserRepository = IUserRepository;
        _IUserEmpreendedorRepository = IUserEmpreendedorRepository;
        _ITransportadorRepository = ITransportadorRepository;

      }
    
      public async Task<bool> Login(string login, string senha){
          Console.WriteLine("projeto feito");

        List<UsuarioConsumidor> usuarioConsumidorList = (await _IUserRepository.selectAll());
        List<UsuarioEmpreendedor> usuarioEmpreendedorList = (await _IUserEmpreendedorRepository.selectAll());
        
        Console.WriteLine("C# kkkk");

        foreach (var usuarioConsumidor in usuarioConsumidorList)
        {
            
            if(usuarioConsumidor.Senha == senha && usuarioConsumidor.Login == login) {
                Console.WriteLine(usuarioConsumidor);
            }
            
        }

        foreach (var usuarioEmpreendedor in usuarioEmpreendedorList)
        {
            if(usuarioEmpreendedor.Senha == senha && usuarioEmpreendedor.Login == login) {
                Console.WriteLine(usuarioEmpreendedor);
            }
            
        }

        /*
        for (int i = 0; i < usuarioEncontrado.Count; i++)
        {
            if(usuarioEncontrado[i].Senha == senha && usuarioEncontrado[i].Login == login){
              MainViewManager.CurrentUser = usuarioEncontrado[i];
              return true;
            }
        }
        */
        return false;
      }


    }
}