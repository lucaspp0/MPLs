using System.Collections.Generic;
using System;
using System.Linq;

using MPL.repository;
using MPL.model;

namespace MPL.controller
{
  public class VendaController
  {

    IVendaRepository _IVendaRepository;
    IItemVendaRepository _IItemVendaRepository;
    IItemEstoqueRepository _IItemEstoqueRepository;

    public VendaController(IVendaRepository IVendaRepository,
                            IItemVendaRepository IItemVendaRepository,
                            IItemEstoqueRepository IItemEstoqueRepository)
    {
      this._IVendaRepository = IVendaRepository;
      this._IItemVendaRepository = IItemVendaRepository;
      this._IItemEstoqueRepository = IItemEstoqueRepository;
    }

    public List<ItemVenda> GetAllItensPendente() =>
      this._IItemVendaRepository.selectAll().FindAll( x => x.Status.ToLower().Contains("pendenter"));

    public bool SalvarVenda(Venda venda) => this._IVendaRepository.save(venda);

    public bool RemoverItemVenda(int idItemVenda) =>
      this._IItemVendaRepository.delete(idItemVenda);

    private void FinalizarItemVenda(ItemVenda itemVenda)
    {
      itemVenda.Status = "Pendente";
      ItemEstoque itemEstoque = _IItemEstoqueRepository.selectAll().Where(x => x.Produto.Id == itemVenda.Produto.Id).FirstOrDefault();
      itemEstoque.Quantidade -= itemVenda.Quantidade;
      _IItemEstoqueRepository.save(itemEstoque);
    }

    public bool FinalizarVenda(Venda venda)
    {
      if (!venda.Finalizado)
      {
        venda.ItemVendas.ForEach(x => FinalizarItemVenda(x));
        venda.Finalizado = true;
        return _IVendaRepository.save(venda);
      }
      else
      {
        return false;
      }
    }

    public Venda ObterVendaPorItemVenda(ItemVenda itemVenda){
      return _IVendaRepository.selectAll().Where(x=>x.ItemVendas.Any(y=>y.Id==itemVenda.Id)).FirstOrDefault();

    }

  }

}
