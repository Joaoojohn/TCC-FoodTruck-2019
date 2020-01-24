using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace food_truck.Databases
{
    class ProdutoDatabases
    {
        //Variavel de Escopo de Classe Entities 

        Model.falcomtccEntities2 db = new Model.falcomtccEntities2();



        //Inserir Item

        public void Inserir(Model.tb_produto produtos)
        {

            db.tb_produto.Add(produtos);

            db.SaveChanges();
        }


        //Consulta pelo nome do Produto

            

        public List<Model.tb_produto> ConsultarN(string produto)
        {

            List<Model.tb_produto> pro =
            db.tb_produto.Where(t => t.nm_produto.Contains(produto)).ToList();

            return pro;
        }


        //Remover item


            public void Remover(Model.tb_produto produto)
        {

            Model.tb_produto remover = db.tb_produto.First(t => t.id_produto == produto.id_produto);

            db.tb_produto.Remove(remover);
            db.SaveChanges();

        }


        //Consulta pelo ID

        public List<Model.tb_produto> ConsultarID(int ID)
        {

            List<Model.tb_produto> turms =
            db.tb_produto.Where(t => t.id_produto == ID).ToList();

            return turms;
        }



        // Listar tudo


        public List<Model.tb_produto> Listar()
        {


            List<Model.tb_produto> turms = db.tb_produto.ToList();

            return turms;
        }



        //Alterar Produto


        public void Alterar(Model.tb_produto produto)
        {
            Model.tb_produto Alterar = db.tb_produto.First(t => t.id_produto == produto.id_produto);

       

            Alterar.nm_produto= produto.nm_produto;
            Alterar.nm_marca = produto.nm_marca;    
            Alterar.ds_produto= produto.ds_produto;
            Alterar.dt_vencimento =produto.dt_vencimento;
            Alterar.dt_entrada  =produto.dt_entrada;
            Alterar.prc_custo = produto.prc_custo;
            Alterar.prc_venda = produto.prc_venda;
            Alterar.qtd_produto =produto.qtd_produto;

            db.SaveChanges();
        }

        public List<Model.tb_produto> Consultar(string conta)
        {

            List<Model.tb_produto> pro =
            db.tb_produto.Where(t => t.nm_produto.Contains(conta)).ToList();

            return pro;
        }


    }
}
