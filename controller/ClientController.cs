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

        public ClientController(IUserRepository IUserRepository, ITransportadorRepository ITransportadorRepository, IUserEmpreendedorRepository IUserEmpreendedorRepository)
        {
            _IUserRepository = IUserRepository;
            _IUserEmpreendedorRepository = IUserEmpreendedorRepository;
            _ITransportadorRepository = ITransportadorRepository;

        }

        public async Task<bool> Login(string login, string senha)
        {

            List<UsuarioConsumidor> usuarioConsumidorList = (await _IUserRepository.selectAll());
            List<UsuarioEmpreendedor> usuarioEmpreendedorList = (await _IUserEmpreendedorRepository.selectAll());
            List<ContaTransportador> usuarioTransportadorList = (await _ITransportadorRepository.selectAll());


            foreach (var usuarioConsumidor in usuarioConsumidorList)
            {

                if (usuarioConsumidor.Senha == senha && usuarioConsumidor.Login == login)
                {
                    Console.WriteLine(usuarioConsumidor);
                    MainViewManager.CurrentUser = usuarioConsumidor;
                    return true;
                }

            }

            foreach (var usuarioEmpreendedor in usuarioEmpreendedorList)
            {
                if (usuarioEmpreendedor.Senha == senha && usuarioEmpreendedor.Login == login)
                {
                    Console.WriteLine(usuarioEmpreendedor);
                    MainViewManager.CurrentUser = usuarioEmpreendedor;
                    return true;
                }

            }
            foreach (var usuarioTransportador in usuarioTransportadorList)
            {
                if (usuarioTransportador.Senha == senha && usuarioTransportador.Login == login)
                {
                    Console.WriteLine(usuarioTransportador);
                    MainViewManager.CurrentUser = usuarioTransportador;
                    return true;
                }

            }
            return false;
        }
    }
}