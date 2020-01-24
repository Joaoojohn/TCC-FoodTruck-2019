using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace food_truck.Databases
{
    class JornadaDeTrabDatabases
    {
        //Variavel de Escopo de Classe Entities

        Model.falcomtccEntities2 db = new Model.falcomtccEntities2();



        //Inserir Item

        public void Inserir(Model.jn_trabalho jor)
        {

            db.jn_trabalho.Add(jor);

            db.SaveChanges();
        }


        //Consulta pelo nome do Produto

        //public List<Model.jn_trabalho> Consultar(string fun)
        //{

        //    List<Model.jn_trabalho> pro =
        //    db.jn_trabalho.Where(t => t. == fun).ToList();

        //    return pro;
        //}


        //Remover item

        public void Remover(int id)
        {

            Model.jn_trabalho remover = db.jn_trabalho.First(t => t.id_jntrabalho == id);

            db.jn_trabalho.Remove(remover);
            db.SaveChanges();

        }


        //Consulta pelo ID

        public List<Model.jn_trabalho> ConsultarID(int ID)
        {

            List<Model.jn_trabalho> turms =
            db.jn_trabalho.Where(t => t.id_jntrabalho == ID).ToList();

            return turms;
        }



        // Listar tudo


        public List<Model.jn_trabalho> Listar()
        {


            List<Model.jn_trabalho> turms = db.jn_trabalho.ToList();

            return turms;
        }



        //Alterar Produto


        ////public void Alterar(Model.jn_trabalho fun)
        ////{
        ////    Model.jn_trabalho Alterar = db.jn_trabalho.First(t => t.id_jntrabalho == fun.id_jntrabalho);

        ////    Alterar.nm_funcionario = fun.nm_funcionario;
        ////    Alterar.tb_entrada = fun.tb_entrada;
        ////    Alterar.tb_saida = fun.tb_saida;

        ////    db.SaveChanges();
        ////}
    }
}
