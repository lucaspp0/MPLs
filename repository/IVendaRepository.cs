using System.Collections.Generic;
using MPL.model;

namespace MPL.repository
{
  public interface IVendaRepository : IBaseRepository<Venda>
  {
      public Venda GetCarrinho(UsuarioConsumidor usuarioConsumidor);
  }

}
