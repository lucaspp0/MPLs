using System.Collections.Generic;
using System.Linq;
using MPL.model;


namespace MPL.repository
{
  public interface IVendaRepository : IBaseRepository<Venda>
  {
      public Venda GetCarrinho(UsuarioConsumidor UsuarioConsumidor);
      public List<Venda> GetVendas(UsuarioConsumidor UsuarioConsumidor);
  }

}
