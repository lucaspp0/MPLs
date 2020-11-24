using System.Collections.Generic;
using System.Linq;
using MPL.model;

namespace MPL.repository.impl
{
  public class VendaRepositoryImpl : BaseRepository<Venda>, IVendaRepository
  {
      public VendaRepositoryImpl(List<Venda> ListObj) : base(ListObj){ }

      public List<Venda> GetVendas(UsuarioConsumidor usuarioConsumidor) =>
        selectAll().FindAll( x => x.Finalizado && x.suarioConsumidor.Id == usuarioConsumidor.Id);

      public Venda GetCarrinho(UsuarioConsumidor usuarioConsumidor){
        Venda venda = selectAll().Where( x => !x.Finalizado && x.suarioConsumidor.Id == usuarioConsumidor.Id).FirstOrDefault();
        if(venda == null){
          venda = new Venda(usuarioConsumidor);
          venda.Finalizado = false;
          venda.ItemVendas = new List<ItemVenda>();
          save(venda);
        }
        return venda;
      }

  }

}
