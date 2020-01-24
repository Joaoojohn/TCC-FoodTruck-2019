using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace food_truck.Databases
{
    class LoginDatabases
    {
        //Variavel de Escopo de Classe Entities

        Model.falcomtccEntities2 db = new Model.falcomtccEntities2();



        //Inserir Item

        public void Inserir(Model.tb_login login)
        {

            db.tb_login.Add(login);

            db.SaveChanges();
        }


        //Consulta pelo nome do Produto

        public List<Model.tb_login> Consultar(string fun)
        {

            List<Model.tb_login> pro =
            db.tb_login.Where(t => t.nm_funcionario == fun).ToList();

            return pro;
        }


        //Remover item

        public void Remover(int id)
        {

            Model.tb_login remover = db.tb_login.First(t => t.id_login == id);

            db.tb_login.Remove(remover);
            db.SaveChanges();

        }


        //Consulta pelo ID

        public List<Model.tb_login> ConsultarID(int ID)
        {

            List<Model.tb_login> turms =
            db.tb_login.Where(t => t.id_login == ID).ToList();

            return turms;
        }


        public List<Model.tb_login> ConsultarPorNome()
        {
            List<Model.tb_login> Consultar = db.tb_login.ToList();

            return Consultar;
        }


        // Listar tudo


        public List<Model.tb_login> Listar()
        {


            List<Model.tb_login> turms = db.tb_login.ToList();

            return turms;
        }



        //Alterar Produto


        public void Alterar(Model.tb_login fun)
        {
            Model.tb_login Alterar = db.tb_login.First(t => t.id_login == fun.id_login);

            Alterar.nm_funcionario = fun.nm_funcionario;
            Alterar.senha = fun.senha;
            

            db.SaveChanges();
        }
    }
}
