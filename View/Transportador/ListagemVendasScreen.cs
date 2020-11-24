using System;

using static MPL.utils.ViewUtils;
using MPL.View.interfaces;
using MPL.model;
using MPL.utils;
using System.Collections.Generic;

namespace MPL.View.Transportador
{
  public class ListagemVendasScreen : IScreen
  {
    public  void Show()
    {
      ShowScreen("Todos os Itens pendentes");
      List<ItemVenda> ItensVendas = Injector.VendaController.GetAllItensPendente();
      ItensVendas.ForEach( x => ShowScreen(x.ToString()) );
    }
  }
}
