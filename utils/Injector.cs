
using System;

using static MPL.utils.ViewUtils;
using MPL.model;
using System.Linq;
using MPL.repository;
using MPL.controller;
using MPL.repository.impl;

namespace MPL.utils
{
  public class Injector
  {
    // repositories
    public static IUserRepository IUserRepository;
    public static IUserEmpreendedorRepository IUserEmpreendedorRepository;
    public static ITransportadorRepository ITransportadorRepository;
    public static IUserConsumidorRepository IUserConsumidorRepository;
    public static IItemEstoqueRepository IItemEstoqueRepository;
    public static IVendaRepository IVendaRepository;
    public static IItemVendaRepository IItemVendaRepository;
    public static IProdutoRepository IProdutoRepository;

    // Controllers
    public static ClientController ClientController;
    public static ClienteConsumidorController ClienteConsumidorController;
    public static ClienteEmpreenderController ClienteEmpreenderController;
    public static CarrinhoController CarrinhoController;
    public static ItemEstoqueController ItemEstoqueController;
    public static ProdutoController ProdutoController;

    public static void initialize()
    {

      // Repositories
      IUserRepository = new UserRepositoryImpl(DataBaseGod._DATABASE.UsuarioConsumidor);
      ITransportadorRepository = new TransportRepositoryImpl(DataBaseGod._DATABASE.ContaTransportador);
      IUserEmpreendedorRepository = new EmpreenderRepositoryImpl(DataBaseGod._DATABASE.UsuarioEmpreender);
      IUserConsumidorRepository = new UserConsumidorRepositoryImpl(DataBaseGod._DATABASE.UsuarioConsumidor);
      IItemEstoqueRepository = new ItemEstoqueRepositoryImpl(DataBaseGod._DATABASE.ItemEstoque);
      IVendaRepository = new VendaRepositoryImpl(DataBaseGod._DATABASE.Venda);
      IItemVendaRepository = new ItemVendaRepositoryImpl(DataBaseGod._DATABASE.ItemVenda);
      IProdutoRepository = new ProdutoRepositoryImpl(DataBaseGod._DATABASE.Produto);

      // Controller
      ClientController = new ClientController(IUserRepository, ITransportadorRepository, IUserEmpreendedorRepository,IVendaRepository,IItemVendaRepository);
      ClienteEmpreenderController = new ClienteEmpreenderController(IUserEmpreendedorRepository);
      ClienteConsumidorController = new ClienteConsumidorController(IUserRepository);
      CarrinhoController = new CarrinhoController(IVendaRepository, IItemVendaRepository);
      ItemEstoqueController = new ItemEstoqueController(IItemEstoqueRepository);
      ProdutoController = new ProdutoController(IProdutoRepository);

    }
  }
}
