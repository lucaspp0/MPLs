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

    public bool ExisteCarrinho(UsuarioConsumidor usuario, Produto produto = null){
      Venda venda = this._IVendaRepository.selectAll()
                    .Where( x => !x.Finalizado && x.UsuarioConsumidory.Id == usuario.Id)
                    .FirstOrDefault();

      if(venda != null && produto != null)
       return venda.ItemVendas.Any( x => x.Produto.Id == produto.Id);
       
      return venda != null;
    }

    public Venda Getcarrinho(UsuarioConsumidor usuario) => this._IVendaRepository.GetCarrinho(usuario);

    public bool AdicionarCarrinho(UsuarioConsumidor usuario, Produto produto, int quantidade, Envio envio = null){
      Venda venda = this._IVendaRepository.GetCarrinho(usuario);
      ItemVenda ItemVenda = venda.ItemVendas.Where( x => x.Produto.Id == produto.Id).FirstOrDefault();
      if(ItemVenda == null){

        if(envio == null) envio = new Correio(false, 50);
        ItemVenda = new ItemVenda(produto: produto, Quantidade: quantidade, Envio: envio);
        
      }else ItemVenda.Quantidade += quantidade;

      return this._IVendaRepository.save(venda) && this._IItemVendaRepository.save(ItemVenda);
    }
    
  }

}
