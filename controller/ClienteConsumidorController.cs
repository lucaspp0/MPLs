using System.Collections.Generic;

using System;
using MPL.View;
using MPL.model;
using MPL.repository;
using System.Threading.Tasks;

namespace MPL.controller
{
    public class ClienteConsumidorController
    {
        IUserRepository _IUserRepository;

        public ClienteConsumidorController(IUserRepository IUserRepository)
        {
            _IUserRepository = IUserRepository;

        }

        public async Task SelecionarProduto(int idProduto)
        {

            List<UsuarioConsumidor> usuarioConsumidorList = (await _IUserRepository.selectAll());

            
        
        }
        
     


           
    }
}