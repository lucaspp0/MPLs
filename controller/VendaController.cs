using System.Collections.Generic;
using System;

using MPL.repository;
using MPL.model;

namespace MPL.controller
{
  public class VendaController
  {

    IVendaRepository _IVendaRepository;
    IItemVendaRepository _IItemVendaRepository;
    IItemEstoqueRepository _IItemEstoqueRepository;

    public VendaController(IVendaRepository IVendaRepository, IItemVendaRepository IItemVendaRepository, IItemEstoqueRepository IItemEstoqueRepository)
    {
      this._IVendaRepository = IVendaRepository;
      this._IItemVendaRepository = IItemVendaRepository;
      this._IItemEstoqueRepository = IItemEstoqueRepository;
    }

    public void FinalizarItemVenda(ItemVenda itemVenda){
      itemVenda.Status = "a Caminho";
    }

    public bool FinalizarVenda(Venda venda){
      if(!venda.Finalizado){
        venda.ItemVendas.ForEach(x => FinalizarItemVenda(x) );
        venda.Finalizado = true;
        return true;
      }else{
        return false;
      }
    }

  }

}
