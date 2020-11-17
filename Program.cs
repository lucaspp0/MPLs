﻿using System.Threading.Tasks;

using MPL.View;
using MPL.utils;
using MPL.repository.impl;

using System;
using System.Threading.Tasks;

using MPL.model;
using MPL.repository;
using MPL.utils;

namespace MPL
{
    public class Program
    {
        
        public async static Task InitializeComponentes(){
            //await BaseRepository<object>.FillBd();
            Injector.initialize();
            Console.WriteLine("final InitializeComponentes");
            // new MainViewManager(new MainScreen()).Start();
        }

        public static IUserRepository _IUserRepository;

        public async static Task init() {
            await Program.InitializeComponentes(); 
            _IUserRepository = Injector.IUserRepository;

            UsuarioConsumidor user = new UsuarioConsumidor();
            user.Cpf = 123;
            user.Login = "123";
            user.Nome = "123";
            user.Senha = "123";
            bool result = await _IUserRepository.save(user);

            // Assert.True(result);
            /*
            await Program.InitializeComponentes(); 
            _IUserRepository = Injector.IUserRepository;
            */
        }

        static void Main(string[] args)
        {
            // InitializeComponentes();
            
            Task mainTask = init();
            while(!mainTask.IsCompleted) { }
            Console.WriteLine("Final geral");
        }
    }
}
