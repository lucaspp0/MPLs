using System.Linq;
using System.Collections.Generic;
using MPL.controller;
using System;

using MPL.utils;
using MPL.model;
using MPL.View.interfaces;
using MPL.repository;
using static MPL.utils.ViewUtils;
using MPL.View.Consumidor.produtos;

namespace MPL.View.Consumidor.vendas
{
  public class MenuCompraScreen : IScreen
  {
    public void Show()
    {
      
      ShowScreen("------Compras do Usuário------");
       
      List<Venda> listProdutcs = Injector.ClientController.returnBuyProducts();

      foreach (var x in listProdutcs)
      {      
        x.ItemVendas.ForEach(item => ShowScreen($"Nome do produto: {item.Produto.Nome} || Quantidade comprada: {item.Quantidade} || Valor do frete: R${item.Frete}"));
      }

      //listProdutcs.ForEach(x => ShowScreen($"depois eu falo com ela {x}") );
        
      
      GetWaitingInput();
      MainViewManager.ChangeScreen(new MenuConsumidorScreen());
    }

    
  }
}
