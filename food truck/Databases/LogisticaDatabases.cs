using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace food_truck.Databases
{
    class LogisticaDatabases
    {
        //Variavel de Escopo de Classe Entities 

        Model.falcomtccEntities2 db = new Model.falcomtccEntities2();



        //Inserir Item

        public void Inserir(Model.tb_logistica logi)
        {

            db.tb_logistica.Add(logi);

            db.SaveChanges();
        }


        //Consulta pelo nome do Produto

        public List<Model.tb_logistica> Consultar(string produto)
        {

            List<Model.tb_logistica> pro =
            db.tb_logistica.Where(t => t.nm_produto == produto).ToList();

            return pro;
        }


        //Remover item

        public void Remover(int id)
        {

            Model.tb_logistica remover = db.tb_logistica.First(t => t.id_logistica == id);

            db.tb_logistica.Remove(remover);
            db.SaveChanges();

        }


        //Consulta pelo ID

        public List<Model.tb_logistica> ConsultarID(int ID)
        {

            List<Model.tb_logistica> turms =
            db.tb_logistica.Where(t => t.id_logistica == ID).ToList();

            return turms;
        }



        // Listar tudo


        public List<Model.tb_logistica> Listar()
        {


            List<Model.tb_logistica> turms = db.tb_logistica.ToList();

            return turms;
        }



        //Alterar Produto


        public void Alterar(Model.tb_logistica produto)
        {
            Model.tb_logistica Alterar = db.tb_logistica.First(t => t.id_logistica == produto.id_logistica);

            Alterar.nm_fornecedor = produto.nm_fornecedor;
            Alterar.nm_produto = produto.nm_produto;
            Alterar.tb_chegada = produto.tb_chegada;
            Alterar.tb_saida = produto.tb_saida;
            Alterar.ed_fornecedor = produto.ed_fornecedor;
            Alterar.ds_produto = produto.ds_produto;


            db.SaveChanges();
        }
    }
}
