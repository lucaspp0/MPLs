using System.Threading.Tasks;
using System;

using MPL.utils;
using MPL.model;
using MPL.repository;
using MPL.View.Transportador;

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
            
            await new MenuTransportadorScreen().Show();

            await Program.InitializeComponentes(); 
            _IUserRepository = Injector.IUserRepository;

            UsuarioConsumidor user = new UsuarioConsumidor();
            user.Cpf = 123;
            user.Login = "123";
            user.Nome = "123";
            user.Senha = "123";
            bool result = await _IUserRepository.save(user);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Inicio de tudo");
            Task mainTask = init();

            while(!mainTask.IsCompleted) { }
            Console.WriteLine("Final geral");
        }
    }
}
