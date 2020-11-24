namespace MPL.model
{
  public class ItemVenda : ABaseModel
  {
    private float frete;
    public float Frete
    {
      get { return frete; }
      set { frete = value; }
    }

    private Produto produto;
    public Produto Produto
    {
      get { return produto; }
      set { produto = value; }
    }

    private string status;
    public string Status
    {
      get { return status; }
      set { status = value; }
    }
    private int quantidade;
    public int Quantidade
    {
      get { return quantidade; }
      set { quantidade = value; }
    }
    private Envio envio;
    public Envio Envio
    {
      get { return envio; }
      set { envio = value; }
    }
    private UsuarioEmpreendedor usuarioEmpreendedor;
    public UsuarioEmpreendedor UsuarioEmpreendedor
    {
        get { return usuarioEmpreendedor; }
        set { usuarioEmpreendedor = value; }
    }
    
    public ItemVenda() { }
    public ItemVenda(Produto produto, int Quantidade, Envio Envio, UsuarioEmpreendedor usuarioEmpreendedor)
    {
      this.UsuarioEmpreendedor = usuarioEmpreendedor;
      this.Quantidade = Quantidade;
      this.status = "Pendente";
      this.produto = produto;
      this.Envio = Envio;
      this.Frete = this.Envio.CalcularFrete(this.produto.Valor);
    }

    public override string ToString()
    {
      return $@"
        Id:         {this.Id}
        Produto:    {this.produto.Nome}
        Quantidade: {this.quantidade}
        Status:     {this.Status}
      ";
    }

  }
}
