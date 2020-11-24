using System;

using static MPL.utils.ViewUtils;
using MPL.View.interfaces;
using MPL.model;
using MPL.utils;
namespace MPL.View.Empreendedor.Vendas
{
  public class VisualizarVendasScreen : IScreen
  {
      public void Show(){
        //Injector.ClienteEmpreenderController.RetornarItemVendas()
        foreach (ItemVenda item in Injector.ClienteEmpreenderController.RetornarItemVendas())
        {
            ShowScreen($@"
              Nome Comprador: {Injector.VendaController.ObterVendaPorItemVenda(item).UsuarioConsumidor.Nome}
              Nome Produto: {item.Produto.Nome},
              Quantidade: {item.Quantidade},
            ");
        }
        GetWaitingInput();
        MainViewManager.ChangeScreen(new MenuEmpreendedorScreen());
      }
  }
}
