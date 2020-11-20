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
        private UsuarioConsumidor clienteLogado;

        public ClienteConsumidorController()
        {
            this.clienteLogado = UsuarioConsumidor MainViewManager.CurrentUser;
            UsuarioConsumidor clienteLogado;   
        }
        
     


           
    }
}