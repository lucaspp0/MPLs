using System;
using MPL.utils;
using static MPL.utils.ViewUtils;
using MPL.View.interfaces;
using MPL.model;
using System.Collections.Generic;

namespace MPL.View.Empreendedor.Vendas
{
    public class CadastrarProdutosScreen : IScreen
    {


        public void Show()
        {
            UsuarioEmpreendedor usuario = (MainViewManager.CurrentUser as UsuarioEmpreendedor);
            string result = GetInput($@"
      1 - Adicionar um novo produto ao estoque
      2 - Adicionar um produto já cadastrado ao estoque
      3 - Sair

Digite a opção: ");

            if (result == "1")
            {
                string nome = GetInput("Insira a nomeclatura do produto: ");
                float peso = GetInputFloat("Insira o peso do produto: ");
                float valor = GetInputFloat("Digite o valor do produto: ");
                string categoria = GetInput("Descreva em qual categoria o produto se encaixa: ");
                int estoqueQtde = GetInputInt("Digite quantos deste produto deseja adicionar ao estoque: ");
                string endereco = GetInput("Digite o endereço onde será estocado o produto: ");
                Injector.ClienteEmpreenderController.CadastrarProdutoEstoque(nome, peso, valor, categoria, estoqueQtde, endereco);
                MainViewManager.ChangeScreen(new MenuEmpreendedorScreen());
            }
            else if (result == "2")
            {
                List<ItemEstoque> lista = usuario.Estoque;
                int i = 0;
                for (i = 0; i < lista.Count; i++)
                {
                    ShowScreen((i + 1) + " - " + lista[i].Produto.Nome);
                }
                ShowScreen("");
                int choose = GetInputInt("Digite o número do produto para adicionar ou para retornar ao menu -1: ");
                
                    if (choose == -1)
                    {
                        MainViewManager.ChangeScreen(new MenuEmpreendedorScreen());
                    }
                    else if (choose >= 0 || choose <= i)
                    {
                        int quantidade = GetInputInt("Digite a quantidade que deseja adicionar de produtos ao determinado Item de Estoque: ");
                        while (quantidade < 1)
                        {
                            quantidade = GetInputInt("Digite um valor válido: ");
                        }
                        Injector.ClienteEmpreenderController.AcrescentarQtde(quantidade, choose-1);
                        MainViewManager.ChangeScreen(new MenuEmpreendedorScreen());
                        
                }
            }
            else if (result == "3")
            {
                MainViewManager.logout();
            }
            else{
              MainViewManager.ChangeScreen(new MenuEmpreendedorScreen());
            }

        }
    }
}
