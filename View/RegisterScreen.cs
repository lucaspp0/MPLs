using System;

using static MPL.utils.ViewUtils;
using MPL.View.interfaces;
using System.Threading.Tasks;

namespace MPL.View
{
  public class RegisterScreen : IScreen
  {
    public async Task Show()
    {
      string tipo = GetInput($@"Tipos de usuários
      1 - Usuário Empreendedor
      2 - Usuário Consumidor
Escolha o tipo de usuário: ");

      ShowScreen($"tipo de usuario {tipo}");
    }
  }
}