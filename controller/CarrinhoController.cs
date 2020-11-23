using System.Collections.Generic;

using System;
using MPL.View;
using MPL.model;
using MPL.repository;

using System.Linq;

namespace MPL.controller
{
  public class CarrinhoController
  {
    private IVendaRepository _IVendaRepository;
    private IItemVendaRepository _IItemVendaRepository;

    public CarrinhoController(IVendaRepository IVendaRepository, IItemVendaRepository IItemVendaRepos)
    {
      this._IVendaRepository = IVendaRepository;
      this._IItemVendaRepository = IItemVendaRepos;
    }

    public bool ExisteCarrinho(UsuarioConsumidor usuario){
      Venda venda = this._IVendaRepository.selectAll()
                    .Where( x => !x.Finalizado && x.UsuarioConsumidory.Id == usuario.Id)
                    .FirstOrDefault();
      return venda != null;
    }

    public bool AdicionarCarrinho(UsuarioConsumidor usuario, Produto produto, int quantidade, Envio envio = null){
      Venda venda = this._IVendaRepository.GetCarrinho(usuario);
      ItemVenda ItemVenda = venda.ItemVendas.Where( x => x.Produto.Id == produto.Id).FirstOrDefault();
      if(ItemVenda == null){
        ItemVenda = new ItemVenda(produto: produto, Quantidade: quantidade, Envio: envio);
      }else{
        ItemVenda.Quantidade += quantidade;
      }
      return this._IItemVendaRepository.save(ItemVenda);
    }
    
  }

}
