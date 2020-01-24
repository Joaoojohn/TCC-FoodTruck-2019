using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace food_truck.Business
{
    class ProdutoBusiness
    {

        Databases.ProdutoDatabases db = new Databases.ProdutoDatabases();

        public void Inserir(Model.tb_produto produto)
        {
            this.Validar(produto);

            db.Inserir(produto);
      
        }

        public void Alterar(Model.tb_produto produto)
        {
            this.Validar(produto);

            db.Alterar(produto);

        }

        public void Remover (Model.tb_produto produto)
        {
            this.Validar(produto);

            db.Remover(produto);

        }

        public List<Model.tb_produto> Listar()
        {
            List<Model.tb_produto> listar = db.Listar();
            return listar;
        }



        public void Validar(Model.tb_produto produto)
        {

            string nome = produto.nm_produto;
            string marca = produto.nm_marca;
            string descrição = produto.ds_produto;
            DateTime venci = produto.dt_vencimento.Value;
            DateTime entrada = produto.dt_entrada.Value;
            decimal prcVenda = produto.prc_venda.Value;
            decimal prcCusto = produto.prc_custo.Value;
            int qtd = produto.qtd_produto.Value;

            if (nome == String.Empty)
            {
                throw new ArgumentException("O campo PRODUTO não pode estar vazio. Por Favor, insira um nome");
            }

            if (marca == String.Empty)
            {
                throw new ArgumentException("O campo MARCA não pode estar vazio. Por Favor, insira um nome");
            }

            if (descrição == String.Empty)
            {
                throw new ArgumentException("O campo DESCRIÇÂO não pode estar vazio. Por Favor, insira um nome");
            }



            if (nome.Length >= 20)
            {
                throw new ArgumentException("Quantidade de Caracteres Excedida: PRODUTO");
            }

            if (marca.Length >= 25)
            {
                throw new ArgumentException("Quantidade de Caracteres Excedida no campo: MARCA");
            }


            if (descrição.Length >= 25)
            {
                throw new ArgumentException("Quantidade de Caracteres Excedida no campo: DESCRIÇÂO ");
            }

            if (qtd == 0)
            {
                throw new ArgumentException("A Quantidade de Produtos não pode ser 0");
            }

            if (prcCusto == 0)
            {
                throw new ArgumentException("O Preço de Custo do Produto não pode ser 0");
            }

            if (prcVenda == 0)
            {
                throw new ArgumentException("O Preço de Venda do Produto não pode ser 0");
            }


            //List<Model.tb_turma> vali = db.ConsultarTurma(turrr);
            //if (vali.Exists(t => t.nm_turma.Equals(turrr)))
            //{
            //    throw new ArgumentException("O nome que foi usado no campo TURMA já exite. Por Favor, insira outro nome.");
            //} 
            //if (tp.produtoins(" ") == true)
            //{
            //    throw new ArgumentException("o campo Curso não pode conter espaço");
            //}
        }
    }
}
