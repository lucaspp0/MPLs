using System;

using static MPL.utils.ViewUtils;
using MPL.View.interfaces;
using MPL.model;
using MPL.utils;
using System.Collections.Generic;
using System.Linq;

namespace MPL.View.Transportador
{
  public class ListagemVendasScreen : IScreen
  {
    public  void Show()
    {
      List<ItemVenda> ItensVendas = Injector.VendaController.GetAllItensPendente();
      ItensVendas.ForEach( x => ShowScreen(x.ToString()) );
      if(ItensVendas.Count == 0){
        MainViewManager.ChangeScreen(new MenuTransportadorScreen());
        ShowScreen("Nenhuma venda pendente");
        GetWaitingInput();
      }else{
        int valor = GetInputInt("Selecione o id da venda para mudar de status ou -1 para sair: ");

        if(valor == -1){
          MainViewManager.ChangeScreen(new MenuTransportadorScreen());
        }else{
          ItemVenda ItemVenda = ItensVendas.Where(x => x.Id == valor).FirstOrDefault();
          if(ItemVenda == null){
            ShowScreen("Venda não encontrada");
            GetWaitingInput();
          }else{
            ItemVenda.Status = "Concluido";
            Injector.VendaController.SalvarItemVenda(ItemVenda);
            Venda venda = Injector.VendaController.ObterVendaPorItemVenda(ItemVenda);
            venda.ItemVendas.Where( x => x.Id == ItemVenda.Id).FirstOrDefault().Status = "Concluido";
            Injector.VendaController.SalvarVenda(venda);
            ShowScreen("status alterado com sucesso");
            GetWaitingInput();
          }
        }

      }
    }
  }
}
