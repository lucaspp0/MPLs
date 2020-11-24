using System.Collections.Generic;
using System.Linq;
using MPL.model;

namespace MPL.repository.impl
{
  public class VendaRepositoryImpl : BaseRepository<Venda>, IVendaRepository
  {
      public VendaRepositoryImpl(List<Venda> ListObj) : base(ListObj){ }

      public List<Venda> GetVendas(UsuarioConsumidor UsuarioConsumidor) =>
        selectAll().FindAll( x => x.Finalizado && x.UsuarioConsumidor.Id == UsuarioConsumidor.Id);

      public Venda GetCarrinho(UsuarioConsumidor UsuarioConsumidor){
        Venda venda = selectAll().Where( x => !x.Finalizado && x.UsuarioConsumidor.Id == UsuarioConsumidor.Id).FirstOrDefault();
        if(venda == null){
          venda = new Venda(UsuarioConsumidor);
          venda.Finalizado = false;
          venda.ItemVendas = new List<ItemVenda>();
          save(venda);
        }
        return venda;
      }

  }

}
