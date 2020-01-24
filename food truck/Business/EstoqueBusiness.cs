using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace food_truck.Business
{
    class EstoqueBusiness
    {
        Databases.EstqueDatabases dg = new Databases.EstqueDatabases();

        public void Inserir(Model.tb_estoque estoque)
        {

            string prod = estoque.ds_produto;
            decimal custo = Convert.ToDecimal (estoque.prc_custo);
            decimal venda = Convert.ToDecimal(estoque.prc_venda);
            int qtd = Convert.ToInt32(estoque.qtd_produto);


            DateTime ent = Convert.ToDateTime(estoque.dt_Entrada);
            DateTime sai = Convert.ToDateTime(estoque.dt_saida);
            DateTime vali = Convert.ToDateTime(estoque.dt_validadeproduto);

           

            if (prod.Length >= 50)
            {
                throw new ArgumentException("Quantidade de Caracteres Excedida");
            }

            if (custo == 0)
            {
                throw new ArgumentException("A quantidade não pode ser 0");
            }
        
            if (venda == 0)
            {
                throw new ArgumentException("A quantidade não pode ser 0");
            }

            if (qtd == 0)
            {
                throw new ArgumentException("A quantidade não pode ser 0");
            }

            if (sai == null)
            {
                throw new ArgumentException("A Data de Saida não pode estar vazio");
            }

            if (ent == null)
            {
                throw new ArgumentException("a Data de entrada não pode estar vazio");
            }

            if (vali == null)
            {
                throw new ArgumentException("a Data de validade não pode estar vazio");
            }






            dg.Inserir(estoque);

        }


        public void Alterar(Model.tb_estoque estoque)
        {


            string prod = estoque.ds_produto;
            decimal custo = Convert.ToDecimal(estoque.prc_custo);
            decimal venda = Convert.ToDecimal(estoque.prc_venda);
            int qtd = Convert.ToInt32(estoque.qtd_produto);


            DateTime ent = Convert.ToDateTime(estoque.dt_Entrada);
            DateTime sai = Convert.ToDateTime(estoque.dt_saida);
            DateTime vali = Convert.ToDateTime(estoque.dt_validadeproduto);



            if (prod.Length >= 50)
            {
                throw new ArgumentException("Quantidade de Caracteres Excedida");
            }

            if (custo == 0)
            {
                throw new ArgumentException("A quantidade não pode ser 0");
            }

            if (venda == 0)
            {
                throw new ArgumentException("A quantidade não pode ser 0");
            }

            if (qtd == 0)
            {
                throw new ArgumentException("A quantidade não pode ser 0");
            }

            if (sai == null)
            {
                throw new ArgumentException("A Data de Saida não pode estar vazio");
            }

            if (ent == null)
            {
                throw new ArgumentException("a Data de entrada não pode estar vazio");
            }

            if (vali == null)
            {
                throw new ArgumentException("a Data de validade não pode estar vazio");
            }

            dg.Alterar(estoque);


        }

        public void Remover(Model.tb_estoque id)
        {

          
            dg.remover(id);

        }

        public List<Model.tb_estoque> Listar()
        {
            List<Model.tb_estoque> listar = dg.Consultar();
            return listar;
        }
     

        public void AlterarTeste(Model.tb_estoque estoque)
        {
            Databases.EstqueDatabases db = new Databases.EstqueDatabases();
            db.AlterarTeste(estoque);
        }
    }
}
