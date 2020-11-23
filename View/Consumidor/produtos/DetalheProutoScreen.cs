// DetalheproutoScreen
using System;

using static MPL.utils.ViewUtils;
using MPL.View.interfaces;
using MPL.model;

namespace MPL.View.Consumidor.produtos
{
  
  public class DetalheProutoScreen : IScreen
  {

    private Produto _produto;
    public DetalheProutoScreen(Produto produto){
      this._produto = produto;
    }
    public void Show()
    {
      ShowScreen("Mostrar dados: " + this._produto.ToString());
    }
  }
}
