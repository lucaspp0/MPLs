using Xunit;
using System;
using System.Threading.Tasks;

using MPL.model;
using MPL.repository;
using MPL.utils;

namespace MPL.teste.repository
{
  public class UserRepositoryTest
  {
    IUserRepository _IUserRepository;
    public async Task init() {
      await Program.InitializeComponentes(); 
      _IUserRepository = Injector.IUserRepository;
    }

    [Fact]
    public async void ShouldSaveTheUser()
    {
      await init();
      UsuarioConsumidor user = new UsuarioConsumidor();
      user.Cpf = 123;
      user.Login = "123";
      user.Nome = "123";
      user.Senha = "123";
      bool result = await _IUserRepository.save(user);
      Assert.True(result);
    }
  }
}