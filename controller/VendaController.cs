using System.Collections.Generic;
using System;

using MPL.repository;

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

  }

}
