using System;
using MPL.utils;
using static MPL.utils.ViewUtils;
using MPL.View.interfaces;


namespace MPL.View.Empreendedor.Vendas
{
  public class CadastrarProdutosScreen : IScreen
  {
 

      public void Show(){
        string result = GetInput($@"
      1 - Adicionar um novo produto ao estoque
      2 - Adicionar um produto já cadastrado ao estoque
      3 - Sair

Digite a opção: ");

        if(result == "1"){
          string nome = GetInput("Insira a nomeclatura do produto: ");
          float peso = float.Parse(GetInput("Insira o peso do produto: "));
          float valor = float.Parse(GetInput("Digite o valor do produto: "));
          string categoria = GetInput("Descreva em qual categoria o produto se encaixa: ");
          int estoqueQtde = int.Parse(GetInput("Digite quantos deste produto deseja adicionar ao estoque: "));
          string endereco = GetInput("Digite o endereço onde será estocado o produto: ");
          Injector.ClienteEmpreenderController.CadastrarProdutoEstoque(nome,peso, valor,categoria,estoqueQtde,endereco);
        }else if(result == "2"){

        }else if(result == "3"){

        }

        string login = GetInput("");
        string senha = GetInput("insira a sua senha: ");



      }
  }
}
