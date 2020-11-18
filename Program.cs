﻿using System.Threading.Tasks;
using System;

using MPL.utils;
using static MPL.utils.ViewUtils;
using MPL.model;
using MPL.repository;
using MPL.View;

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

        public async static Task init() {
            
           // await new MenuTransportadorScreen().Show();

            await Program.InitializeComponentes(); 
           // _IUserRepository = Injector.IUserRepository;
            //new MainViewManager(new LoginScreen()).Start();
            new MainViewManager(new MainScreen()).Start();
/*
            UsuarioConsumidor user = new UsuarioConsumidor();
            user.Cpf = 123;
            user.Login = "123";
            user.Nome = "123";
            user.Senha = "123";
            */
           // bool result = await _IUserRepository.save(user);
        }

        static void Main(string[] args)
        {
            ClearConsole();
            Task mainTask = init();

            while(!mainTask.IsCompleted) { }
            Console.WriteLine("Final geral");
        }
    }
}
